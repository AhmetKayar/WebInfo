using App.Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.WebInfo.Entities.Concrete
{
    public class Personal:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PersonalId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(100)]
        public string Soyadi { get; set; }
        [Required]
        [MaxLength(100)]
        public string BabaAdi { get; set; }
        [Required]
        [MaxLength(100)]
        public string AnaAdi { get; set; }
        
        [MaxLength(20)]
        public string DogumTarihi { get; set; }
        
        [MaxLength(100)]
        public string DogumYeri { get; set; }
        
        [MaxLength(100)]
        public string KayitliOlduguIl { get; set; }
        
        [MaxLength(100)]
        public string KayitliOlduguIlce { get; set; }
        [MaxLength(100)]
        public string AdliIslemDurumu { get; set; }
        [MaxLength(500)]
        public string Mahalle { get; set; }
        [MaxLength(200)]
        public string Sokak { get; set; }
        [MaxLength(100)]
        public string No { get; set; }
        [MaxLength(30)]
        public string Telefon { get; set; }
        [MaxLength(10)]
        public string AileNo { get; set; }
        [MaxLength(100)]
        public string Kacak { get; set; }
        [MaxLength(100)]
        public string IslemiYapan { get; set; }
        [MaxLength(100)]
        public string SosyalYardimDurumu { get; set; }
        [MaxLength(10)]
        public string Cinsiyet { get; set; }
        [MaxLength(100)]
        public string MedeniDurumu { get; set; }

        public string Uygurugu { get; set; }
        public string Mezhep { get; set; }
        public string EtnikKoken { get; set; }
        public string EgitimDurumu { get; set; }
        public string Meslegi { get; set; }
        public string Dini { get; set; }
        public string SaglikDurumu { get; set; }
        public string KanGrubu { get; set; }
        public string Beden { get; set; }
        public string AyakkabiNo { get; set; }
        public string KayitTarihi { get; set; }
        public string KayitTipi { get; set; }
        public string Durumu { get; set; }
        public string KampAdi { get; set; }
        public string KampIli { get; set; }
        public string KampBolgesi { get; set; }
        public string KampMahallesi { get; set; }
        public string KonteynerNo { get; set; }

    }
}
