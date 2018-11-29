using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;
namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP_COSTING_MATERIALS")]
    public class tbl_100_WIP_COSTING_MATERIALS
    {
        [NotMapped]
        [Browsable(false)]
        public string state { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 RecID { get; set; }
        [Browsable(false)]
        public int YEARUSED { get; set; }
        [Browsable(false)]
        public string ItemNo { get; set; }
        [Browsable(false)]               
        public string PartNo { get; set; }
        public string MatCode { get; set; }
        public string MatDescription { get; set; }
        public Decimal Usage { get; set; }
        public string UnitType { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal Amount { get; set; }
        [Browsable(false)]
        public string Address { get; set; }
        [Browsable(false)]
        public Decimal Ratio { get; set; }
        [Browsable(false)] 
        public Decimal TotalMaterial { get; set; }
        [Browsable(false)] 
        public string KartCode { get; set; }
        [Browsable(false)]
        public Decimal Total { get; set; }
    }
}
