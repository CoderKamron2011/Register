//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
using Register.Services;
using Register.Models;
class Program
{
    static IUserService UserService = new UserService();
    static bool isContinueProject = true;
    static void Main(string[] args)
    {
        do
        {
            PrintMenu();
            
            Console.Write("Enter your command: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("SignUp");
                    Users users = new Users();
                    Console.Write("Enter your Email here ==> ");
                    users.Email = Console.ReadLine();
                    Console.Write("Enter your Password here ==> ");
                    users.Pasword = Console.ReadLine();

                    UserService.SignUp(users);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("LogIn");
                    Users user2 = new Users();
                    Console.Write("Enter your Email here ==> ");
                    user2.Email = Console.ReadLine();
                    Console.Write("Enter your Password here ==> ");
                    user2.Pasword = Console.ReadLine();

                    UserService.LogIn(user2);
                    break;
            }
            Console.Write("Is Continue(yes / no): ");
            string isContinue = Console.ReadLine();
            if (isContinue.Contains("no"))
            {
                isContinueProject = false;
            }

        } while (isContinueProject is true);
    }

    private static void PrintMenu()
    {
        Console.WriteLine("Welcome to, registation");
        Console.WriteLine("1. SignUp");
        Console.WriteLine("2. LogIn");
        
    }
}

