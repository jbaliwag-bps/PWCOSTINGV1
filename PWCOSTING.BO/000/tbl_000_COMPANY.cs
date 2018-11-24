using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_COMPANY")]
    public class tbl_000_COMPANY : BaseStatusClass
    {
        public tbl_000_COMPANY() {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            DateDeactivated = DateTime.Now;
            YearList = new List<tbl_YEAR>();
        }

        #region "Not Mapped"
        [NotMapped]
        public List<tbl_YEAR> YearList { get; set; }
        #endregion

        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string COMPANY { get; set; }
        public string SHORTNAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string TELNOS { get; set; }
        public string MOBILENOS { get; set; }
        public string FAXNOS { get; set; }
        public string EMAIL { get; set; }
        public byte[] LOGO {get;set;}
    }
}
