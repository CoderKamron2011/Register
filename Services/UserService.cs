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
            return user is null
                ? InvalidLogInUser()
                : ValidationAndLogIn(user);
        }
        public Users SignUp(Users user)
        {
            return user is null
                ? InvalidSignUp()
                : ValidationAndSignUpUser(user);
        }
        private Users InvalidSignUp()
        {
            this.loggingBroker.LogError("User information is null.");
            return new Users();
        }
        private Users ValidationAndSignUpUser(Users user)
        {
            if (String.IsNullOrWhiteSpace(user.Email)
              || String.IsNullOrWhiteSpace(user.Pasword))
            {
                this.loggingBroker.LogError("Invalid user information.");
                return new Users();
            }
            else
            {
                var userInformation = this.storageBroker.SignUpUser(user);
                if (userInformation is null)
                {
                    this.loggingBroker.LogError("Not added user info");
                }
                else
                {
                    this.loggingBroker.LogInformation("Added user");
                }
                return userInformation;
            }
        }
        private bool InvalidLogInUser()
        {
            this.loggingBroker.LogError("Sizning login yoki parolingiz noto'g'ri kiritilgan");
            return false;
        }
        private bool ValidationAndLogIn(Users user)
        {
            if (String.IsNullOrWhiteSpace(user.Email)
                || String.IsNullOrWhiteSpace(user.Pasword))
            {
                this.loggingBroker.LogError("Incoming data is incomplete");
                return false;
            }
            else
            {
                bool userInfo = this.storageBroker.CheckoutUser(user);
                if (userInfo is true)
                {
                    this.loggingBroker.LogInformation("successful");
                }
                else
                {
                    this.loggingBroker.LogError("Not found");
                }
                return userInfo;
            }
        }
    }
}
