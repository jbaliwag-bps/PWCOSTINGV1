using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP_COSTING_LABOR_BAGGING")]
    public class tbl_100_WIP_COSTING_LABOR_BAGG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 RecID { get; set; }
        [Browsable(false)]
        public int YEARUSED { get; set; }
        [Browsable(false)]
        public string ItemNo { get; set; }
        [Browsable(false)]
        public string PartNo { get; set; }
        public string ProcessName { get; set; }
        public Decimal HC { get; set; }
        public Decimal QTY { get; set; }
        public Decimal T_Time { get; set; }
    }
}
