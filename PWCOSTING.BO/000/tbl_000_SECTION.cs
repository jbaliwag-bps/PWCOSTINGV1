using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_SECTION")]
    public class tbl_000_SECTION : BaseStatusClass
    {
         public tbl_000_SECTION() {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            DateDeactivated = DateTime.Now;
        }
         [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
         public int RecID { get; set; }
        [Key]
        [Required]
         public string SECTIONCODE { get; set; }
        [Required]
        public string SECTIONDESC { get; set; }
        public Boolean ISCOSTING { get; set; }
        public string SUPERVISOR { get; set; }
    }
}
