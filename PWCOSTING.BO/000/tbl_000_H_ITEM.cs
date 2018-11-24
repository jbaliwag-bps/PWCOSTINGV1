using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM")]
    public class tbl_000_H_ITEM
    {
        [NotMapped]
        public List<tbl_000_H_ITEM_PART> itemCom { get; set; }
        [NotMapped]
        public List<tbl_000_H_ITEM_TABULATION> itemPI { get; set; }
        [NotMapped]
        public List<tbl_000_H_ITEM_TABULATION_VP> itemVP { get; set; }
        [NotMapped]
        public List<tbl_000_H_ITEM_TABULATION_ASSY> itemAssy { get; set; }
        [NotMapped]
        public List<tbl_000_H_ITEM_MPT> itemMPT { get; set; }
        [NotMapped]
        public List<tbl_000_H_ITEM_FDC> itemFDC { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 DocID { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int YEARUSED { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public string ItemNo { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string CatCode { get; set; }
        public string CatDesc { get; set; }
        public string SubCatCode { get; set; }
        public int LotQTY { get; set; }
        public int ProdMonth { get; set; }
        public DateTime LastUpdated { get; set; }
        public Boolean IsLocked { get; set; }
        public DateTime LockedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set;}
        public Boolean IsCopied { get; set; }
        public DateTime CopyDate { get; set; }
        public Boolean IsImported { get; set; }
        public DateTime ImportDate { get; set; }
        public string ImportBy { get; set; }
    }
}
