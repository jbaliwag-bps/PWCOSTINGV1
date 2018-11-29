using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;
namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM_TABULATION")]
    public class tbl_000_H_ITEM_TABULATION
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
        public Decimal AcquisitionCost { get; set; }
        public Decimal DepQty { get; set; }
        public Decimal QtyProduced { get; set; }
        public Decimal MoldCost { get; set; }
        public Decimal ESTSHHR { get; set; }
        public Decimal Cavity { get; set; }
        public Decimal ESTPCSHR { get; set; }
        public Decimal ESTHC { get; set; }
        public Decimal MoldSetUpTime { get; set; }
        public string Oz { get; set; }
        public Decimal Purge_G { get; set; }
        public Decimal OPTime { get; set; }
        public string MoldSize { get; set; }
        public Decimal ACTSHHR { get; set; }
        public Decimal ACTPCSHR { get; set; }
        public Decimal ACTHC { get; set; }
        public Decimal DepnMold { get; set; }
        [Browsable(false)]
        public Boolean IsCopied { get; set; }
        [Browsable(false)]
        public DateTime CopyDate { get; set; }
    }
}
