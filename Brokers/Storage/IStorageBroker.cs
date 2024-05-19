﻿//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
using Register.Models;

namespace Register.Broker.Storage
{
    internal interface IStorageBroker
    {
        bool CheckoutUser(Users user);
        Users ReadUser(Users user);
        Users SignUpUser(Users user);
    }
}
