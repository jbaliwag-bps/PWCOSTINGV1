using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWCOSTING.BO.Default
{

    [Table("tbl_MENU")]
    public class tbl_MENU
    {
        [Key]
        [Display(Name = "MenuID")]
        public int MenuID { get; set; }

        [Display(Name = "MenuName")]
        public string MenuName { get; set; }

        [Display(Name = "MenuOrder")]
        public int MenuOrder { get; set; }

        [Display(Name = "ParentMenuID")]
        public int ParentMenuID { get; set; }

        [Display(Name = "FormName")]
        public string FormName { get; set; }

        [Display(Name = "ImageName")]
        public string ImageName { get; set; }

        [Display(Name = "IsShortCut")]
        public bool IsShortCut { get; set; }

        [Display(Name = "ShortcutName")]
        public string ShortcutName { get; set; }

        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
        public bool IsLeftAlign { get; set; }

        [Display(Name = "CreatedDate")]
        public DateTime CreatedDate { get; set; }

    }

    public class tbl_MENU_Search
    {
        public tbl_MENU_Search()
        {
            Selected = false;
        }
        public Boolean Selected { get; set; }
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public string ParentName { get; set; }
    }
}
