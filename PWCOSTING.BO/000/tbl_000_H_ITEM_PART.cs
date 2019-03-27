using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM_PART")]
    public class tbl_000_H_ITEM_PART
    {
        [NotMapped]
        [Browsable(false)]
        public string state { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 DocID { get; set; }
        [Required]
        [Browsable(false)]
        public int YEARUSED { get; set; }
        [Required]
        public string ItemNo { get; set; }
        [Required]
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string PartType { get; set; }
        public string ItemAddress { get; set; }
        public Decimal ItemUsage { get; set; }
        public string SectionCode { get; set; }
        public string ItemVendor { get; set; }
        public string ItemUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal Amount { get; set; }
        [Browsable(false)]
        public string MoldNo { get; set; }
        [Browsable(false)]
        public Boolean IsCopied { get; set; }
        [Browsable(false)]
        public DateTime CopyDate { get; set; }
        [Browsable(false)]
        public Boolean IsImported { get; set; }
        [Browsable(false)]
        public DateTime ImportDate { get; set; }
        [Browsable(false)]
        public string ImportBy { get; set; }
    }
}
