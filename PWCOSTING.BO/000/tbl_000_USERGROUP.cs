using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO;

namespace PWCOSTING.BO._000
{
    public class tbl_000_USERGROUP : BaseStatusClass
    {
        [NotMapped]
        public List<tbl_000_USERGROUP_MENUS> MenuList { get; set; }

        public tbl_000_USERGROUP()
        {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            DateDeactivated = DateTime.Now;
            MenuList = new List<tbl_000_USERGROUP_MENUS>();
        }

        public string GroupID { get; set; }

        [Key]
        [Required]
        public string UserGroupCode { get; set; }
        [Required]
        public string UserGroupDesc { get; set; }
        public string Remarks { get; set; }        
    }
}
