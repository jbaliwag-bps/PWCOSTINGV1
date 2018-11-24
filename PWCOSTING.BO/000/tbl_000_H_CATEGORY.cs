using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO;

namespace PWCOSTING.BO._000
{
    public class tbl_000_H_CATEGORY : BaseStatusClass
    {
          public tbl_000_H_CATEGORY() {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            DateDeactivated = DateTime.Now;
        }
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public Int64 RecID { get; set; }
          [Key, Column(Order = 1)]
          [Required]
          public string CATCODE { get; set; }
          [Key, Column(Order = 13)]
          [Required]
          public int YEARUSED { get; set; }
          public string CATDESC { get; set; }
          public Decimal RATECONVERSION { get; set; }
          public Decimal FIXEDCHARGELABOR { get; set; }
          public Decimal FIXEDCHARGEFO { get; set; }
          public Decimal PRODALLOWANCETIME { get; set; }
          public Decimal FIXEDRATELOSS { get; set; }
          public Decimal FIXEDRATEPROFIT { get; set; }
          public Decimal YENRATECONVERSION { get; set; }
          public Decimal FIXEDRATEDEPNMOLD { get; set; }
          public Decimal FIXEDRATEDEPNFILM { get; set; }
          public Decimal OTHERPROCESSCOST { get; set; }
          public Decimal MoldSetup { get; set; }
          public Decimal LotSize { get; set; }
          public Boolean IsDependent { get; set; }
    }
}
