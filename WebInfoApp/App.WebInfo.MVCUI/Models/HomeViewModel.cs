using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.MVCUI.Models
{
    public class HomeViewModel
    {
        public List<HomeReporBoxModel> ReporBoxModels { get; set; }
    }

    public class HomeReporBoxModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public long Count { get; set; }
        public long Progress { get; set; }
        public string Icon { get; set; }
    }

    public class ImportModel
    {
        public string file { get; set; }
        public List<Personal> Personals { get; set; }
    }
}
