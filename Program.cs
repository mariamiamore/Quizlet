using System;
namespace Quizlet
{
	public class Program
	{
		public static void Main (string[]args)
		{
			Console.WriteLine("\t     QUIZLET");
			Console.WriteLine("\tEnter to proceed...");
			Welcome();
		}			
			public static void Welcome()
			{
				Console.ReadLine();	
				Console.Clear();
				Console.WriteLine("\t     Welcome to Quizlet");
				string ans = "";
			
                Console.WriteLine("\t1. Log in");
                Console.WriteLine("\t2. Sign up");
                Console.WriteLine("\t3. Exit");
				Console.WriteLine("\t------------------------------");
                Console.Write("\tChoose an option: ");
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
                        Console.WriteLine("\tInvalid input. Please Try again. [Enter]");
						Welcome();
                        break;
                }
		
			static void Signup()
			{
				Console.Clear();
				Console.WriteLine("\t       Sign up");
				Console.Write("\tEnter your username: ");
				string username = Console.ReadLine();

				if (Account.Username.Contains(username))
				{
					Console.WriteLine("\tThe username already exist.");
					Console.WriteLine("\t\tPress Enter to go back.");
					Welcome();
				}
				else 
				{
					Account.Username.Add(username);
					Console.WriteLine("\tSign up successfully. Please try to log in. [Enter]");
					Console.WriteLine("\t------------------------------");
					Welcome();
				}
			}
			
			static void Login()
			{
				Console.Clear();
				Console.WriteLine("\t       Login");
				Console.Write("\tEnter your username: ");
				string username = Console.ReadLine();
				Console.WriteLine("\tLogging you in....");
				Console.WriteLine();
			
				if (Account.Login(username)) 	
				{
					Menu.Show(username);
				}
				else
				{
					Console.WriteLine("\tUsername does not exist. Sign up first. [Enter]");
					Console.WriteLine("\t------------------------------");
					Console.WriteLine();
					Welcome();
				}
			}
		}
	}
}