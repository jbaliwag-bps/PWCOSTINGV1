using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP_COSTING_LABOR_PI")]
    public class tbl_100_WIP_COSTING_LABOR_PI
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 RecID { get; set; }
        [Browsable(false)]
        public int YEARUSED { get; set; }
        [Browsable(false)]
        public string ItemNo { get; set; }
        [Browsable(false)]
        public string Partno { get; set; }
        public string MoldNo { get; set; }
        public Decimal SPH { get; set; }
        public Decimal Cavity { get; set; }
        public Decimal Usage { get; set; }
        public Decimal ComputationSPH { get; set; }
        public Decimal ComputationCavity { get; set; }
        public Decimal TUsage { get; set; }
        public Decimal Allowance { get; set; }
        public Decimal TotalTime { get; set; }
        [Browsable(false)]
        public Decimal Amount { get; set; }
        [Browsable(false)]
        public DateTime TmStmp { get; set; }
        [Browsable(false)]
        public string PartNoMem { get; set; }
    }
}
