//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
using Register.Models;
namespace Register.Services
{
    internal interface IUserService 
    {   
        Users LogIn(Users user);         
        Users SignUp(Users user);  
    }
}   
