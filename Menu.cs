using System;

namespace Quizlet
{
    internal class Menu
    {
        public static List<string> QuizletMenu = new List<string>();
        
        public static string user = "";

        public static void Menus()
        {
            QuizletMenu.Clear();

            QuizletMenu.Add("Add a folder");
            QuizletMenu.Add("Folder");
            QuizletMenu.Add("Sign out");
        }

        public static void Show(string User)
        {
            user = User;
            Console.Clear();
            Console.WriteLine("\t    Welcome, " + user + "!");
            Console.WriteLine();

            Menus();
            for (int i = 0; i < QuizletMenu.Count; i++)
            {
                Console.WriteLine("\tEnter " + (i + 1) + " to " + QuizletMenu[i]);
            }
            Console.WriteLine("\t------------------------------");
            Console.Write("\tChoose option: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opt)
            {
                case 1:
                    Functions.AddingFolder();
                    break;

                case 2:
                    Functions.FolderList();
                    break;

                case 3:
                    Functions.Signout();
                    break;

                default:
                    Console.WriteLine("\tInvalid option. Choose again. [Enter]");
                    Console.ReadLine();
                    Show(user);
                    break;
            }
        }
   }
}