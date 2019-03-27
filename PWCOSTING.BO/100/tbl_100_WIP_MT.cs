using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;


namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP_MT")]
    public class tbl_100_WIP_MT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 RecID { get; set; }
        [Key, Column(Order = 1)]
        public int YEARUSED { get; set;}
        [Key, Column(Order = 2)]
        public string PartNo { get; set; }
        public string PartName { get; set;}
        public Decimal Usage { get; set; }
        public string Process { get; set; }
        public string Vendor { get; set; }
       
    }
}
