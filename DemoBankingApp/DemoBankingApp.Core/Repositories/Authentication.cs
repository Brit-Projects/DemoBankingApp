using DemoBankingApp.Core.Models;
using System.Xml.Linq;

namespace DemoBankingApp.Core.Repositories
{
    public class Authentication
    {
        List<Users> users = new List<Users>

        {
            new Users{ UserId= 1, UserName = "Linda Belcher", Email = "lin_belcher@burgers.com", Password = "I<3wine987" },
            new Users{ UserId = 2, UserName = "Bob Belcher", Email = "bob_belcher@burgers.com", Password = "I<3burgers123" }
        };

        public List<Users> GetUsers()
        {
            return users;
        }

        public void AddUser(Users user)
        {
            users.Add(user);
        }

        public Users SetNewUser(int userId, string userName, string email, string password) 
        {
            return new Users { UserId = userId, UserName = userName, Email = email, Password = password };
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

            Users newUser = SetNewUser(rand.Next(), name, email, password);
            AddUser(newUser);
            Console.WriteLine($"User added: {newUser.UserName}");
            return;
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
            bool isAMatch = false;

            foreach (Users user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    Console.WriteLine($"Welcome {user.UserName}");
                    isAMatch = true;
                    break;
                    // todo: check if user has at least one bank account
                        // if yes: Display dashboard
                        // if no: Create account
                }
                else
                {
                    isAMatch= false;
                }
            }


            if (!isAMatch)
            {
                Console.WriteLine("Email or Password do not match");
            }

            return;
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
                    Console.WriteLine("please choose one of the options");
                    break;

            }

            return;
        }

        string welcomeMessage = "Welcome to this bank";
        string optionsMessage = "Please choose 1 to register or 2 to login";

        public int GetUserInput(int intInput)
        {
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
            Console.WriteLine(optionsMessage);

            var input = 0;

            input = GetUserInput(input);
            getOption(input);
  

            return;

        }

        // method to choose option to register or login

        // if register add user

        // if log in, authenticate

        /*
        //public void welcomeUser()
        //{
        //    Console.WriteLine(welcomeMessage);
        //    Console.WriteLine(optionsMessage);
        //}

        //public int parseUserOption()
        //{
        //    var userInput = Console.ReadLine();

        //    try
        //    {
        //        int intInput = int.Parse(userInput);
        //        return intInput;
        //    }
        //    catch (FormatException)
        //    {
        //        return 0;
        //    }

        //}

        //public void processInput()
        //{
        //    int userInput = parseUserOption();
        //    switch (userInput)
        //    {
        //        case 1:
        //            Console.WriteLine("Register");
        //            break;
        //        case 2:
        //            Console.WriteLine("Log in");
        //            break;
        //        case 0:
        //            Console.WriteLine("Invalid input format");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid option");

        //    }

        //}
        */



    }
}
