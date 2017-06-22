using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class Personal : EntitiyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PersonalId { get; set; }


        public virtual IkametDurumu IkametDurumu { get; set; }

        [Required]
        [MaxLength(6)]
        public string AileNo { get; set; }
        [Required]
        [MaxLength(6)]
        public string SahisNo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(100)]
        public string Soyadi { get; set; }

        [MaxLength(15)]
        public string Telefon { get; set; }

        [Required]
        [MaxLength(100)]
        public string BabaAdi { get; set; }
        [Required]
        [MaxLength(100)]
        public string AnaAdi { get; set; }

        [MaxLength(20)]
        public string DogumTarihi { get; set; }

        public virtual DogumYeri DogumYeri { get; set; }

        public virtual Il Il { get; set; }
        public virtual Ilce Ilce { get; set; }
        [MaxLength(500)]
        public string Mahalle { get; set; }
        [MaxLength(200)]
        public string Sokak { get; set; }
        [MaxLength(100)]
        public string KapiNo { get; set; }

        public virtual Din Din { get; set; }

        public virtual Uyruk Uyruk { get; set; }

        public virtual MedeniDurumu MedeniDurumu { get; set; }

        [MaxLength(100)]
        public string Mezhep { get; set; }

        public virtual Koken Koken { get; set; }

        public virtual EgitimDurumu EgitimDurumu { get; set; }

        [MaxLength(200)]
        public string Okul { get; set; }

        [MaxLength(100)]
        public string Sinif { get; set; }

        [MaxLength(200)]
        public string Meslegi { get; set; }

        [MaxLength(50)]
        public string KayitTarihi { get; set; }

        public virtual IslemYapan IslemYapan { get; set; }

        public string KayitTipi { get; set; }
        public virtual KayitDurumu KayitDurumu { get; set; }

        [MaxLength(200)]
        public string KampAdi { get; set; }
        public virtual Il KampIl { get; set; }
        public virtual Ilce KampBolgesi { get; set; }
        [MaxLength(200)]
        public string KampMahallesi { get; set; }
        [MaxLength(200)]
        public string KonteynerNo { get; set; }

        public virtual SosyalYardimDurumu SosyalYardimDurumu { get; set; }
        [MaxLength(500)]
        public string SosyalYardimAciklama { get; set; }

        public virtual Cinsiyet Cinsiyet { get; set; }

        public virtual SaglikDurumu SaglikDurumu { get; set; }

        [MaxLength(500)]
        public string SaglikDurumuAciklama { get; set; }

        public virtual KanGrubu KanGrubu { get; set; }

        public int Bedeni { get; set; }

        public int AyakkabiNo { get; set; }

        [MaxLength(500)]
        public string AdliIslemDurumu { get; set; }


    }

}
