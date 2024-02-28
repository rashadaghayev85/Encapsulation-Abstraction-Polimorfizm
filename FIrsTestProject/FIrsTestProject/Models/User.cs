using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrsTestProject.Models
{
    internal class User:BaseEntity
    {
        public string fullName;
        public string email;
        public string password;
        public int age;
    }
}
