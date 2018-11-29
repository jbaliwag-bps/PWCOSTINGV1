using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;
namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM_FDC")]
    public class tbl_000_H_ITEM_FDC
    {
        [NotMapped]
        [Browsable(false)]
        public string state { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 DocID { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int YEARUSED { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public string ItemNo { get; set; }
        [Key, Column(Order = 3)]
        [Required]
        public string DepnType { get; set; }
        public string Description { get; set; }
        public Decimal FDC_QTY { get; set; }
        public Decimal AcquisitionCost { get; set; }
        public Decimal DepnQTY { get; set; }
        public Decimal DepnCost { get; set; }
        public Decimal DepnFilm { get; set; }
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
