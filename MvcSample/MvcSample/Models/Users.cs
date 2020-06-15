using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

    }
}