using FIrsTestProject.Helpers.Constants;
using FIrsTestProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrsTestProject.Controllers
{
    internal class AccountController
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Login()
        {
            Email: Console.WriteLine("enter email");
            string email=Console.ReadLine();
            if (!email.Contains("@gamil.com"))
            {
                Console.WriteLine(ResponseMessages.IncorrectEmailFormat);
                goto Email;
            }
            Console.WriteLine("enter password");
            string password=Console.ReadLine(); 
            var result=_accountService.Login(email, password);
            if (result)
            {
                Console.WriteLine(ResponseMessages.LoginSucces);
            }
            else
            {
                Console.WriteLine(ResponseMessages.LoginFailed);
            }
        }
    }
}
