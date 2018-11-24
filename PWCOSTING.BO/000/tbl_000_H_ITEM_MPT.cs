using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_ITEM_MPT")]
    public class tbl_000_H_ITEM_MPT
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Int64 DocID { get; set; }
        [Required]
        public int YEARUSED { get; set; }
        [Required]
        public string ItemNo { get; set; }
        [Required]
        public string SectionCode { get; set; }
        public string SectionName { get; set; }
        public Decimal ProductionTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Boolean IsCopied { get; set; }
        public DateTime CopyDate { get; set; }
    }
}
