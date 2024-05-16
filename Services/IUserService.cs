//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
using Register.Models;
namespace Register.Services
{
    internal interface IUserService
    {
        bool LogIn(Users user);
        Users SignUp(Users user);
    }
}
