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
        public Users LogIn(Users user )
        {
            return user is null
                ? InvalidLogInByEmail()
                : ValidationAndLogIn(user);
        }

        private Users ValidationAndLogIn(Users user)
        {
            Users isUser = this.storageBroker.ReadUser(user);
            if (isUser is not null)
            {
                this.loggingBroker.LogInformation("Success.");
                return isUser;
            }
            else
            {
                this.loggingBroker.LogError("No data found for this Email.");
                return new Users();
            }
        }

        public Users SignUp(Users user)
        {
            return new Users();
        }
        private Users InvalidLogInByEmail()
        {
            this.loggingBroker.LogError("Invalid.");
            return new Users();
        }
    }
}
