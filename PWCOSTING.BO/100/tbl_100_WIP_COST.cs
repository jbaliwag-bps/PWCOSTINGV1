using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP_COST")]
   public class tbl_100_WIP_COST
    {
        [NotMapped]
        [Browsable(false)]
        public string state { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 RecID { get; set; }
        public int YEARUSED { get; set; }
        public string ItemNo { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public Decimal MatLaborCost { get; set; }
        public Decimal ProfitRate { get; set; }
        public Decimal TSellingPrice { get; set; }
        public Decimal Forex { get; set; }
        public string Ref_Add { get; set; }
        public Decimal TPInjec { get; set; }
        public Decimal TBagging { get; set; }
        public Decimal TAssembled { get; set; }
        public Decimal TPlating { get; set; }
        public Decimal AllwPLInjec { get; set; }
        public Decimal AllwBagging { get; set; }
        public Decimal AllwAssembled { get; set; }
        public Decimal AllwPlating { get; set; }
        public Decimal PLO1 { get; set; }
        public Decimal PLO2 { get; set; }
        public Decimal PLO3 { get; set; }
        public Decimal PLO4 { get; set; }
        public Decimal SPL1 { get; set; }
        public Decimal SPL2 { get; set; }
        public Decimal SPL3 { get; set; }
        public Decimal SPL4 { get; set; }
        public Decimal LLabor1 { get; set; }
        public Decimal LLabor2 { get; set; }
        public Decimal LLabor3 { get; set; }
        public Decimal LLabor4 { get; set; }
        public Decimal SPPInjec { get; set; }
        public Decimal SPBagging { get; set; }
        public Decimal SPAssembled { get; set; }
        public Decimal SPPlating { get; set; }
        public Decimal DollarInjec { get; set; }
        public Decimal DollarBagging { get; set; }
        public Decimal DollarAssembled { get; set; }
        public Decimal DollarPlating { get; set; }
    }
}
