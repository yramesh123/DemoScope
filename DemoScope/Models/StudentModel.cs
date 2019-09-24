using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoScope.Models
{
    [Table("tbl_Students")]
    public class StudentModel
    {
       public  string FirstName { get; set; }

       public  string LastName { get; set; }

        [Key]
        public  Decimal RollNumber { get; set; }

        public string IdNum { get; set; }

    }
}
