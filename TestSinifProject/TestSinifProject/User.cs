using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSinifProject
{
    internal class User
    {
        public string name;
        public string surName;
        public int age; 
        private string password;

        public User(string name,string surName,int age)
        {
            this.name = name;
            this.surName = surName;
            this.age = age;
        }
        public void SetMethod(string password)
        {
            this.password=password;
        }
        public string GetMethod()
        {
            
            return   password;

        }
        
    }
}
