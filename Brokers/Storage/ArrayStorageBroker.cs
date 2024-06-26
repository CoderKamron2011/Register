﻿//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
using Register.Models;
using System.Diagnostics;

namespace Register.Broker.Storage
{
    internal class ArrayStorageBroker : IStorageBroker
    {
        private Users[] UsersInfo { get; set; } = new Users[10];
        public ArrayStorageBroker()
        {
            this.UsersInfo[0] = new Users()
            {
                Name = "Kamron",
                Email = "kamronbek@gmail.com",
                Pasword = "sjjssjjs"
            };
            this.UsersInfo[1] = new Users()
            {
                Email = "afruzbek@gmail.com",
                Name = "afruz",
                Pasword = "afruzcoder"
            };
        }
        public Users SignUpUser(Users user)
        {
            for (int iteration = 0; iteration < UsersInfo.Length; iteration++)
            {
                if (UsersInfo[iteration] is null)
                {
                    var UserInfo = new Users()
                    {
                        Email = user.Email,
                        Pasword = user.Pasword
                    };
                    UsersInfo[iteration] = UserInfo;
                    return user;
                }
            }
            return new Users();
        }
        public bool CheckoutUser(Users user)
        {
            for (int itaration = 0; itaration < UsersInfo.Length; itaration++)
            {
                var userInformation = UsersInfo[itaration];
                if (userInformation is not null)
                {
                    if (userInformation.Email == user.Email && userInformation.Pasword == user.Pasword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Users ReadUser(Users user, string Email)
        {
            for (int itaration = 0; itaration < UsersInfo.Length; itaration++)
            {
                if (UsersInfo[itaration] is not null)
                {
                    if (UsersInfo[itaration].Email == Email)
                    {
                        return UsersInfo[itaration];
                    }
                }
            }

            return new Users();
        }

        public Users ReadUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}