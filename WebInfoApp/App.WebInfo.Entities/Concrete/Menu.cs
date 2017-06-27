using App.Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.WebInfo.Entities.Concrete
{
    public class Menu:IEntity
    {
        public Menu()
        {
            SubMenu = new List<Menu>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MenuId { get; set; }

        public long ParentId { get; set; }

        [Required]
        [Display(Name = "Menu Link")]
        [MaxLength(100)]
        public string MenuUrl { get; set; }

        [Required]
        [Display(Name = "Menu Adı")]
        [MaxLength(100)]
        public string MenuName { get; set; }

        public MenuIcon MenuIcon { get; set; }

        public bool IsActive { get; set; }

        public string UserType { get; set; }

        public int Order { get; set; }

        public ICollection<Menu> SubMenu { get; set; }
    }
    public enum MenuIcon
    {
        Home,
        Settings,
        Pointer,
        Feed,
        SocialDribbble,
        User,
        Docs,
        Basket,
        Wrench,
        Layers,
        BarChart,
        Wallet,
        Briefcase,
        Bulb,
        Puzzle,
        Diamond,
        Graph,
        CreditCard,
        Calendar,
        Grid,
        Check,
        List,
        Users
    }
}
