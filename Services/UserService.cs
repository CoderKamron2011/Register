using Register.Broker.Storage;
using Register.Brokers.Logging;
using Register.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
namespace Register.Services
{
    internal class UserService : IUserService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStorageBroker storageBroker;
        public UserService()
        {
            this.loggingBroker = new LoggingBroker();
            this.storageBroker = new ArrayStorageBroker();
        }
        public bool LogIn(Users user)
        {
            
        }

        public Users SignUp(Users user)
        {
              
        }
        
    }
}
