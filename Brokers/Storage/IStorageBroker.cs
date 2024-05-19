//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
using Register.Models;

namespace Register.Broker.Storage
{
    internal interface IStorageBroker
    {
        bool CheckoutUser(Users user);
        Users ReadUser(Users user, string Email);
        Users ReadUser(string email);
        Users SignUpUser(Users user);
    }
}
