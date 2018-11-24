using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_tmp_300_H_STANDARD_COSTING_Q01_SUMMARY")]
    public class tbl_tmp_300_H_STANDARD_COSTING_Q01_SUMMARY
    {
        [Key]
        public string ItemNo { get; set; }
        public string DESCRIPTION { get; set; }
        public string CATCODE { get; set; }
        public string SUBCATCODE { get; set; }
        public Decimal MATCOST { get; set; }
        public Decimal LABORCOST { get; set; }
        public Decimal OTHERPROCESSCOST { get; set; }
        public Decimal PROCESSCOST { get; set; }
        public Decimal FOCOST { get; set; }
        public Decimal CEQ { get; set; }
        public Decimal SUBTOTAL { get; set; }
        public Decimal MPA1 { get; set; }
        public Decimal MPA2 { get; set; }
        public Decimal DEPNMOLD { get; set; }
        public Decimal DDF { get; set; }
        public Decimal TOTALINPESO { get; set; }
        public Decimal TOTALDOLLAR1 { get; set; }
        public Decimal TOTALDOLLAR2 { get; set; }
        public Decimal SUBTOTAL_DOLLAR { get; set; }
        public Decimal PROFIT { get; set; }
        public Decimal SELLINGPRICE { get; set; }
        public Decimal rateConversion { get; set; }
        public Decimal PURGECOST { get; set; }
        public Decimal FREIGHT1 { get; set; }
        public Decimal SELLINGPRICEAMT { get; set; }
    }
}
