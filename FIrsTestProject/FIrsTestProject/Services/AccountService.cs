﻿using FIrsTestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FIrsTestProject.Services
{
    internal class AccountService
    {
        private readonly UserService _userService;
        public AccountService()
        {
            _userService=new UserService();
        }
        public bool Login(string email, string password)
        {
            var users = _userService.GetAll();
            //return users.Any(m => m.email == email && m.password == password);
            var user=users.FirstOrDefault(m=>m.email == email && m.password == password);
            return user==null?false:true;
        }
    }
}
