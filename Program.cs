using System;
namespace Quizlet
{
	public class Program
	{
		public static void Main (string[]args)
		{
			Console.WriteLine("QUIZLET");
			Console.WriteLine("Enter to proceed...");
			Welcome();
		}			
			public static void Welcome()
			{
			Console.ReadLine();	
			Console.Clear();
			Console.WriteLine("Welcome to Quizlet");
			string ans = "";
			
                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Sign up");
                Console.WriteLine("3. Exit");
				Console.WriteLine("------------------------------");
                Console.Write("Choose an option: ");
                ans = Console.ReadLine();
				  switch(ans)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        Signup();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break; 

                    default:
                        Console.WriteLine("Invalid input. Please Try again. [Enter]");
						Welcome();
                        break;
                }
		
			static void Signup()
			{
			Console.Write("Enter your username: ");
			string username = Console.ReadLine();

			if (Account.Username.Contains(username))
			{
				Console.WriteLine("The username already exist.");
				Console.WriteLine("Press Enter to go back.");
				Welcome();
			}
			else 
			{
				Account.Username.Add(username);
            	Console.WriteLine("Sign up successfully. Please try to log in. [Enter]");
				Console.WriteLine("------------------------------");
				Welcome();
			}
			}
			static void Login()
			{
			Console.Write("Enter your username: ");
			string username = Console.ReadLine();
			
			
			Console.WriteLine("Logging you in....");
			Console.WriteLine();
			
			if (Account.Login(username)) 	
			{
				Menu.Show(username);
			}
			else
			{
				Console.WriteLine("Username does not exist. Sign up first. [Enter]");
				Console.WriteLine("------------------------------");
				Console.WriteLine();
				Welcome();
			}

			}
		}
	}
}