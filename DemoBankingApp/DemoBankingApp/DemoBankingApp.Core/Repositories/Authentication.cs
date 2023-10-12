using DemoBankingApp.Core.Models;
using DemoBankingApp.Core.Services;
using System.Xml.Linq;

namespace DemoBankingApp.Core.Repositories
{
    public class Authentication
    {
        List<User> users = new List<User>

        {
            new User{ UserId= 1, UserName = "Linda Belcher", Email = "linda@linda.com", Password = "password" },
            new User{ UserId = 2, UserName = "Bob Belcher", Email = "bob_belcher@burgers.com", Password = "I<3burgers123" }
        };

        public void AddUser(User user)
        {
            users.Add(user);
        }        
        
        public List<User> GetUsers()
        {
            return users;
        }



        public User SetNewUser(int userId, string userName, string email, string password) 
        {
            return new User { UserId = userId, UserName = userName, Email = email, Password = password };
        }


        public void RegisterUser()
        {
            string name;
            string email;
            string password;

            do
            {
                Console.WriteLine("Please enter your name: (Field cannot be empty)");
                name = Console.ReadLine();

                Console.WriteLine("Please enter your email: (Field cannot be empty)");
                email = Console.ReadLine();

                Console.WriteLine("Please enter a password: (Field cannot be empty)");
                password = Console.ReadLine();

            } while (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password));
            

            var rand = new Random();

            User newUser = SetNewUser(rand.Next(), name, email, password);
            AddUser(newUser);
        }

 
        public void LoginUser()
        {
            string email;
            string password;
            do
            {
                Console.WriteLine("Please enter your email: (Field cannot be empty)");
                email = Console.ReadLine();

                Console.WriteLine("Please enter a password: (Field cannot be empty)");
                password = Console.ReadLine();

            } while (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password));
            

            var users = GetUsers();

            foreach (User user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    Console.WriteLine($"Welcome {user.UserName}");

                    DashboardService dashboardService = new DashboardService();

                    dashboardService.DisplayDashboard(user);

                    // todo: check if user has at least one bank account
                        // if yes: Display dashboard
                        // if no: Create account
                }
                else
                {
                    Console.WriteLine("Email or Password do not match");
                }
            }
        }

        public void getOption(int intInput)
        {
            switch (intInput)
            {
                case 0:
                    Console.WriteLine("please choose one of the options");
                    break;
                case 1:
                    Console.WriteLine("Let's register you :)");
                    RegisterUser();
                    break;
                case 2:
                    LoginUser();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }

        string welcomeMessage = "Welcome to this bank";
        string optionsMessage = "Please choose 1 to register or 2 to login";

        public int GetUserInput(int intInput)
        {
            Console.WriteLine(optionsMessage);

            var userInput = Console.ReadLine();

            try
            {
                intInput = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input format");
            }

            return intInput;


        }

        public void WelcomeUser()
        {
            Console.WriteLine(welcomeMessage);

            var input = 0;

            do
            {
                input = GetUserInput(input);
                getOption(input);

            } while (input != 1 || input != 2);

        }





    }
}
