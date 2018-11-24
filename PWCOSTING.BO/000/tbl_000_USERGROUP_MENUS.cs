using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWCOSTING.BO._000
{

    [Table("tbl_000_USERGROUP_MENUS")]
    public class tbl_000_USERGROUP_MENUS
    {

        [Key, Column(Order=1)]
        [Display(Name = "UserGroupCode")]
        public string UserGroupCode { get; set; }

        [Key, Column(Order=2)]
        [Display(Name = "MenuID")]
        public int MenuID { get; set; }

        [Display(Name = "MenuName")]
        public string MenuName { get; set; }

        [Display(Name = "CanAdd")]
        public bool CanAdd { get; set; }

        [Display(Name = "CanEdit")]
        public bool CanEdit { get; set; }

        [Display(Name = "CanDelete")]
        public bool CanDelete { get; set; }

        [Display(Name = "CanView")]
        public bool CanView { get; set; }

        [Display(Name = "CanPrint")]
        public bool CanPrint { get; set; }

        [Display(Name = "CanPreview")]
        public bool CanPreview { get; set; }

        [Display(Name = "DateCreated")]
        public DateTime DateCreated { get; set; }

    }
}
