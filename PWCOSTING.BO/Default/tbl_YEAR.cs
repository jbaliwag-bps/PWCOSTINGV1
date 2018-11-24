using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWCOSTING.BO.Default
{
    [Table("tbl_YEAR")]
    public class tbl_YEAR
    {
        public tbl_YEAR()
        {
            DateCreated = DateTime.Now;
        }

        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int RecID {get;set;}

        [Key]
        [Required]
        public int RecYear { get; set; }
        public Boolean IsLocked { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
