using FIrsTestProject.Helpers.Constants;
using FIrsTestProject.Models;
using FIrsTestProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrsTestProject.Controllers
{
    internal class UserController
    {
        private readonly UserService _userService;
        
        public UserController()
        {
            _userService = new UserService();
            
        }
        public void GetAll()

        {
            var result = _userService.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.fullName + " " + item.email + " " + item.age);
            }

        }
        public void GetUserById()
        {

        UserId: Console.WriteLine("Enter search id:");

            string Strid = Console.ReadLine();
            int id;
           
            bool isCorretId=int.TryParse(Strid, out id);
            var user = _userService.GetUserById(_userService.GetAll(), id);
            if (isCorretId)
            {
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.NotFound);
                    return;

                }

                Console.WriteLine(user.fullName + " " + user.email + " " + user.age);
            }


            else
            {
                Console.WriteLine(ResponseMessages.IncorrectNumberFormat);
                goto UserId;

            }




        }





    }
}
