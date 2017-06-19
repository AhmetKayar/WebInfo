using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class Il
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IlId { get; set; }
        [Required]
        [MaxLength(100)]
        public string IlName { get; set; }
        public virtual List<Ilce> Ilceler { get; set; }
    }

}
