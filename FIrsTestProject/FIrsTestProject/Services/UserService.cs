using FIrsTestProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrsTestProject.Services
{
    internal class UserService:User
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                id = 1,
                fullName = "Rashad Aghayev",
                email = "user1@gmail.com",
                age = 21,
                password = "password",
            };
            User user2 = new()
            {
                id = 2,
                fullName = "Sadiq Imanov",
                email = "user2@gmail.com",
                age = 20,
                password = "password",
            };
            User user3 = new()
            {
                id = 3,
                fullName = "Cavid Gasimov",
                email = "user3@gmail.com",
                age = 18,
                password = "password",
            }; User user4 = new()
            {
                id = 4,
                fullName = "Elvin Elizade",
                email = "user4@gmail.com",
                age = 19,
                password = "password",
            };
            User[] users =  { user1, user2, user3, user4, };
            return users;

        }
       public User GetUserById(User[] users,int id)
        { 
          
            return users.FirstOrDefault(m => m.id == id);
            if (users == null) return null;

        }
    }
}
