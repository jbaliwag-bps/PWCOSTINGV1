using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ASSY")]
    public class tbl_000_H_ASSY
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 DocID { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int YEARUSED { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public Decimal HC { get; set; }
        public Decimal Qty { get; set; }
        public Decimal RATEPERHOUR { get; set; }
        public Boolean IsLocked { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Boolean IsCopied { get; set; }
        public DateTime CopyDate { get; set; }
        public Boolean IsImported { get; set; }
        public DateTime ImportDate { get; set; }
        public string ImportBy { get; set; }
    }
}
