using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{


    public class UserDepart
    {
        public IEnumerable<Users> Users { get; set; }
        public IEnumerable<Department> Department { get; set; }
    }
}