using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    public class tbl_000_USER : BaseStatusClass
    {
        [NotMapped]
        public tbl_000_USERGROUP UserGroup { get; set; }
        [NotMapped]
        public List<tbl_MENU> MenuList { get; set; }

        public tbl_000_USER()
        {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            DateDeactivated = DateTime.Now;
        }

        public string UserID { get; set; }

        [Key]
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string FullName { get; set; }
        public string UserGroupCode { get; set; }
        public string UserGroupDesc { get;set;}
        public string SectionCode { get; set; }
        public string SectionDesc { get; set; }
        public string AccessLevel { get; set; }
        public Byte[] UserPhoto { get; set; }
    }
}
