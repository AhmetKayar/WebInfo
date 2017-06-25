using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using App.WebInfo.Business.Abstract;
using App.WebInfo.MVCUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using App.WebInfo.Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;

namespace App.WebInfo.MVCUI.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IPersonalService _personalService;
        private readonly IHostingEnvironment _environment;

        public HomeController(IPersonalService personalService, IHostingEnvironment environment)
        {
            _personalService = personalService;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            List<HomeReporBoxModel> reportBoxs = new List<HomeReporBoxModel>();
            long totalPersonalCount = await _personalService.Count(x => !x.IsDelete);
            reportBoxs.Add(new HomeReporBoxModel
            {
                Count = totalPersonalCount,
                Title = "Toplam Yabancı Sayısı",
                SubTitle = "Yabancı Sayısı",
                Icon = "icon-user",
                Progress = 100
            });

            //Okuyor Id 3
            long egitimGorenCount =
                await _personalService.Count(x => !x.IsDelete && x.EgitimDurumu.EgitimDurumuId == 3);
            reportBoxs.Add(new HomeReporBoxModel
            {
                Count = egitimGorenCount,
                Progress = (100 * egitimGorenCount) / totalPersonalCount,
                Title = "Eğitim Gören Yapıncı Sayısı",
                SubTitle = "Eğitim Gören",
                Icon = "icon-user"
            });

            reportBoxs.Add(new HomeReporBoxModel
            {
                Count = await _personalService.Count(x => !x.IsDelete),
                Title = "Toplam Yabancı Sayısı",
                SubTitle = "Yabancı Sayısı",
                Icon = "icon-user"
            });
            var model = new HomeViewModel
            {
                ReporBoxModels = reportBoxs
            };
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }

        public async Task<IActionResult> ImportFile()
        {
            return View(new ImportModel() { Personals = new List<Personal>() });
        }

        [HttpPost]
        public async Task<IActionResult> ImportFile(IFormFile importFile)
        {
            List<Personal> personals = new List<Personal>();
            string newFileName = FileUpload(importFile);
            string sWebRootFolder = _environment.WebRootPath;
            string sFileName = Path.Combine("uploads", newFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            try
            {
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int rowCount = worksheet.Dimension.Rows;
                    for (int row = 2; row <= rowCount; row++)
                    {
                        if (worksheet.Cells[row, 1] != null)
                        {
                            var personal = new Personal
                            {
                                SahisNo = CheckString(worksheet.Cells[row, 1].Value),
                                Adi = CheckString(worksheet.Cells[row, 2].Value),
                                Soyadi = CheckString(worksheet.Cells[row, 3].Value),
                                BabaAdi = CheckString(worksheet.Cells[row, 4].Value),
                                AnaAdi = CheckString(worksheet.Cells[row, 5].Value),
                                DogumTarihi = CheckString(worksheet.Cells[row, 6].Value),
                                AileNo = CheckString(worksheet.Cells[row, 16].Value)
                            };
                            personals.Add(personal);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            //await _personalService.Add(personals);
            Parallel.For(0, personals.Count, i =>
            {
                var itemResult = AddPersonal(personals[i]);
            });

            ImportModel model = new ImportModel
            {
                Personals = personals
            };
            return View(model);
        }

        public string CheckString(object check)
        {

            if (check==null || check.ToString().Trim().Length == 0)
            {
                return "Boş";
            }
            return check.ToString();
        }
        public async Task<bool> AddPersonal(Personal item)
        {
            await _personalService.Add(item);
            return true;
        }
        private string FileUpload(IFormFile imageFile)
        {
            var newFileName = string.Empty;

            if (imageFile != null && imageFile.Length > 0)
            {
                var path = Path.Combine(_environment.WebRootPath, "uploads");
                var fileName = imageFile.FileName;
                var imageType = fileName.Substring(fileName.LastIndexOf('.'),
                    fileName.Length - fileName.LastIndexOf('.'));
                newFileName = Guid.NewGuid() + "-" + imageType;

                using (Stream fs = System.IO.File.Create(Path.Combine(path, newFileName)))
                {
                    if (fs != null)
                    {
                        imageFile.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
            return newFileName;
        }

        [HttpGet]
        public IActionResult Import()
        {
            string sWebRootFolder = _environment.WebRootPath;
            string sFileName = Path.Combine("uploads", "demo.xlsx");
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            try
            {
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    StringBuilder sb = new StringBuilder();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int rowCount = worksheet.Dimension.Rows;
                    int ColCount = worksheet.Dimension.Columns;
                    bool bHeaderRow = true;
                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= ColCount; col++)
                        {
                            if (bHeaderRow)
                            {
                                sb.Append(worksheet.Cells[row, col].Value.ToString() + "\t");
                            }
                        }
                        sb.Append(Environment.NewLine);
                    }
                    return View(new ImportModel() { file = sb.ToString() });
                }
            }
            catch (Exception ex)
            {

            }
            return View();
        }
    }
}
