using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._000
{
    [Table("tbl_000_H_PI")]
    public class tbl_000_H_PI
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 DocID { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int YEARUSED { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public string MoldNo { get; set; }
        public string MoldName { get; set; }
        public Decimal SPH { get; set; }
        public Decimal Cavity { get; set; }
        public Decimal PPH { get; set; }
        public Decimal Usage { get; set; }
        public Decimal MolSetUpTime { get; set; }
        public string Oz { get; set; }
        public Decimal PurgePerG { get; set; }
        public Boolean IsLocked { get; set; }
        [Browsable(false)]
        public DateTime CreatedDate { get; set; }
        [Browsable(false)]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        [Browsable(false)]
        public Boolean IsCopied { get; set; }
        [Browsable(false)]
        public DateTime CopyDate { get; set; }
        [Browsable(false)]
        public Boolean IsImported { get; set; }
        [Browsable(false)]
        public DateTime ImportDate { get; set; }
        [Browsable(false)]
        public string ImportBy { get; set; }
    }
}
