using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoScope.Models
{
    [Table("tbl_teachers") ]
    public class TeacherModel
    {
        [Key]
        public Decimal EmpId { get; set; }

        public string EmpName { get; set; }

        public string Phone { get; set; }


    }
}
