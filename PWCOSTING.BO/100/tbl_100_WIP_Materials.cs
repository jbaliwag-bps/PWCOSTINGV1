using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP_Materials")]
    public class tbl_100_WIP_Materials
    {
        [NotMapped]
        [Browsable(false)]
        public string state { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 RecID { get; set; }
        [Key, Column(Order = 1)]
        public int YEARUSED { get; set; }
        [Key, Column(Order = 2)]
        public string ItemNo { get; set; }
        [Key, Column(Order = 3)]
        public string PartNo { get; set; }
        [Key, Column(Order = 4)]
        public string MatCode { get; set; }
        public string MatDescroption { get; set; }
        public Decimal Usage { get; set; }
        public string UnitType { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal Amount { get; set; }
        public string Address { get; set; }
    }
}
