using FIrsTestProject.Controllers;
using FIrsTestProject.Models;
using FIrsTestProject.Services;

//User user = new User();
//AccountService accountService = new AccountService();
UserController userController = new UserController();
//userController.GetAll();
//userController.GetUserById();

//userController.Login();

AccountController accountController = new AccountController();
accountController.Login();