using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;
using System.ComponentModel;

namespace PWCOSTING.BO._100
{
    [Table("tbl_100_WIP")]
    public class tbl_100_WIP
    {
        public tbl_100_WIP()
        {
           CreatedDate = DateTime.Now;
           UpdatedDate = DateTime.Now;
        }

        [NotMapped]
        public List<tbl_100_WIP_Materials> WIPMaterials { get; set; }
        
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
        public string PartCode { get; set; }
        public string PartName { get; set; }
        public string CatCode { get; set; }
        public Decimal MaterialLabor { get; set; }
        public Decimal ProfitRate { get; set; }
        public Decimal SellingPrice { get; set; }
        public Decimal ForexRate { get; set; }
        public DateTime CreatedDate { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Remarks { get; set; }
    }
}
