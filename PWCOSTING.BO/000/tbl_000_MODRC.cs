using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_MODRC")]
    public class tbl_000_MODRC
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 RecID { get; set; }
        [Key]
        [Required]
        public string MODRCCode { get; set; }
        public string Description { get; set; }
        public Decimal Time { get; set; }
        public Boolean IsCosting { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateDeactivated { get; set; }
    }
}
