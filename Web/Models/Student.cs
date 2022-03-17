using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Students.Models
{
    public class Student
    {
        public int StudentID { get; set; } 

        [StringLength(20), Required]
        public string Name { get; set; }

        [Range(0 ,100)]
        public int Marks { get; set; }
    }
}
