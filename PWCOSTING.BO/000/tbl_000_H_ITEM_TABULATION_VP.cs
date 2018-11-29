using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;
namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM_TABULATION_VP")]
    public class tbl_000_H_ITEM_TABULATION_VP
    {
        [NotMapped]
        [Browsable(false)]
        public string state { get; set; }

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
        [Browsable(false)]
        public DateTime CreatedDate { get; set; }
        [Browsable(false)]
        public string CreatedBy { get; set; }
        [Browsable(false)]
        public Boolean IsCopied { get; set; }
        [Browsable(false)]
        public DateTime CopyDate { get; set; }
    }
}
