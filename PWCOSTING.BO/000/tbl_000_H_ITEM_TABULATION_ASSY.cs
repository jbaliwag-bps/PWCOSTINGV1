using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM_TABULATION_ASSY")]
    public class tbl_000_H_ITEM_TABULATION_ASSY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 DocID { get; set; }
        [Required]
        public int YEARUSED { get; set; }
        [Required]
        public string ItemNo { get; set; }
        [Required]
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public Decimal OPPI { get; set; }
        public Decimal OPASSY { get; set; }
        public Decimal STDRATEPERHOUR { get; set; }
        public Decimal Usage { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Boolean IsCopied { get; set; }
        public DateTime CopyDate { get; set; }
    }
}
