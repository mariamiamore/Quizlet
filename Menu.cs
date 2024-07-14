using System;

namespace Quizlet
{
    internal class Menu
    {
        public static List<string> QuizletMenu = new List<string>();
        public static List<string> Folders = new List<string>();
        
        
        public static string user = "";

        public static void Menus()
        {
            QuizletMenu.Clear();

            QuizletMenu.Add("Add a folder");
            QuizletMenu.Add("Folders");
            QuizletMenu.Add("Sign out");
        }

        public static void Show(string User)
        {
            user = User;
            Console.Clear();
            Console.WriteLine("Welcome, " + user + "!");
            Console.WriteLine();

            Menus();
            for (int i = 0; i < QuizletMenu.Count; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " to " + QuizletMenu[i]);
            }
            Console.WriteLine("------------------------------");
            Console.Write("Choose option: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opt)
            {
                case 1:
                    AddFolder();
                    break;

                case 2:
                    ShowFolders();
                    break;

                case 3:
                    Functions.Signout();
                    break;

                default:
                    Console.WriteLine("Invalid option. Choose again. [Enter]");
                    Console.ReadLine();
                    Show(user);
                    break;
            }
        }

        

        public static void AddFolder()
        {
            string folderTitle = "";
            Console.Clear();
            Console.WriteLine("Type 1 to Back");
            Console.Write("Enter folder title: ");
            folderTitle = Console.ReadLine();

            if (folderTitle == "1")
            {
                Show(user);
            }
            else
            {
                Folders.Add(folderTitle); 
                Console.WriteLine("Folder added successfully!");
                FolderMenu(folderTitle); 
            }
           
        }

        public static void FolderMenu(string folderTitle)
        {
            Console.Clear();
            Console.WriteLine(folderTitle);
            Console.WriteLine();

            List<string> folderMenu = new List<string>();
            folderMenu.Add("Make a reviewer");
            folderMenu.Add("Flashcards");
            folderMenu.Add("Take a quiz");
            folderMenu.Add("Back");

            for (int i = 0; i < folderMenu.Count; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " to " + folderMenu[i]);
            }

            Console.Write("Choose option: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opt)
            {
                case 1:
                    Functions.MakingReviewer(); 
                    FolderMenu(folderTitle); 
                    break;

                case 2:
                    Functions.FlashCards(); 
                    FolderMenu(folderTitle);
                    break;

                case 3:
                    Functions.TakingQuiz(); 
                    FolderMenu(folderTitle); 
                    break;

                case 4:
                    Show(user);
                    break;

                default:
                    Console.WriteLine("Invalid option. Choose again. [Enter]");
                    Console.ReadLine();
                    FolderMenu(folderTitle); 
                    break;
            }
        }

        public static void ShowFolders()
        {

            if (Folders.Count == 0)
            {
                Console.WriteLine("There is nothing to see here. [Enter]");
                Console.ReadLine();
                Show(user); 
            }
            
            else
            {
                Console.Clear();
                Console.WriteLine("Folders");
                Console.WriteLine();
                Console.WriteLine("Enter 1 to Back");
                for (int i = 0; i < Folders.Count; i++)
                {
                    
                    Console.WriteLine("Enter " + (i + 2) + " to " + Folders[i]);
                }
                Console.WriteLine("------------------------------");

                Console.Write("Choose a folder: ");
                int folderOpt = Convert.ToInt32(Console.ReadLine());
                
                switch (folderOpt)
                {
                    case 1:
                    Show(user);
                    break;

                    case 2:
                    FolderMenu(Folders[2 - folderOpt]);
                    break;

                    default:
                    Console.WriteLine("Try again.[Enter]");
                    Console.ReadLine();
                    ShowFolders();
                    break;
                }
            }
        }
    }
}