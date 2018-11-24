using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PWCOSTING.BO.Default;


namespace PWCOSTING.BO._000
{
    [Table("tbl_DEFAULT")]
    public class tbl_DEFAULT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RecID { get; set; }
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }
        public string StatusUsage { get; set; }
        public int StatusOrder { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
