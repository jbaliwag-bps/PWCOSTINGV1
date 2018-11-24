using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP_COSTING_ITEM")]
    public class tbl_100_WIP_COSTING_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 RecID { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int YEARUSED { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public string ItemNo { get; set; }
        [Key, Column(Order = 3)]
        [Required]
        public string PartNo { get; set; }
        public Decimal ForexRate { get; set; }
        public Decimal MaterialLabor { get; set; }
        public Decimal ProfitRate { get; set; }
        [Key, Column(Order = 4)]
        [Required]
        public string Ref_Add { get; set; }
    }
}
