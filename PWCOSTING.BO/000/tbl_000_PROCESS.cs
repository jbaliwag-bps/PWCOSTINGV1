using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_PROCESS")]
    public class tbl_000_PROCESS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 RecID { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int YEARUSED { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public string SubProcessCode { get; set; }
        public string ProcessCode { get; set; }
        public string ItemDescription { get; set; }
        public Decimal StandardA { get; set; }
        public Decimal StandardB { get; set; }
        public string Remarks { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime ?DeactivatedDate { get; set; }
        public string DeactivatedNote { get; set; }
        public DateTime ?CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ?UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Boolean IsCopied { get; set; }
        public DateTime CopyDate { get; set; }
        public Boolean IsImported { get; set; }
        public DateTime ImportDate { get; set; }
        public string ImportBy { get; set; }
    }
}
