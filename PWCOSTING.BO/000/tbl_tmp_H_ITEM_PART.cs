using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_tmp_H_ITEM_PART")]
    public class tbl_tmp_H_ITEM_PART
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 DocID { get; set; }
        public string ItemAddress { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public Decimal ItemUsage { get; set; }
        public string Process { get; set; }
        public string ItemVendor { get; set; }
        public string Bagging { get; set; }
    }
}
