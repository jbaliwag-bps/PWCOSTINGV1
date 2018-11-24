using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM_TABULATION_VP")]
    public class tbl_000_H_ITEM_TABULATION_VP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 DocID { get; set; }
        [Required]
        public int YEARUSED { get; set; }
        [Required]
        public string ItemNo { get; set; }
        [Required]
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string VP_Operation { get; set; }
        public string SourceData { get; set; }
        public Decimal TotalTime { get; set; }
        public Decimal TotalQty { get; set; }
        public Decimal ActualTimePerUnit { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Boolean IsCopied { get; set; }
        public DateTime CopyDate { get; set; }
    }
}
