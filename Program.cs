//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------
using Register;
using Register.Services;
using Register.Models;
class Program
{
    static IUserService flowerService = new UserService();
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
                    Users users = new Users();  

                    break;
                case "2":
                    
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
        Console.WriteLine("Welcome to, our project");
        Console.WriteLine("1. SignUp");
        Console.WriteLine("2. LogIn");
        
    }
}

