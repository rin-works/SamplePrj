using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "{0}は必須です。")]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}