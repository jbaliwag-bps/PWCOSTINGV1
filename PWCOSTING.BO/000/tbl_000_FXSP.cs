using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_FXSP")]
    public class tbl_000_FXSP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 RecID { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public string RecType { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public DateTime EffectiveDate { get; set; }
        public Decimal Rate { get; set; }
        public int YearUsed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
