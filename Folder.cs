using System;

namespace Quizlet
{
    internal class Folder
    {
	public static List<string>Folders = new List<string>();
	
		public static void AddFolder()
        {
            string folderTitle = "";
            Console.Clear();
            Console.WriteLine("\tType 1 to Back");
            Console.Write("\tEnter folder title: ");
            folderTitle = Console.ReadLine();
			Folders.Add(folderTitle); 
			
            if (folderTitle == "1")
            {
                Menu.Show(Menu.user);
            }
			else if (Folders.Count ==1)
			{
			  Console.WriteLine("\tFolder added successfully!");
              FolderMenu(folderTitle); 
			}
            else 
            {
			if (Folders.Count >=1)
				{
					Console.WriteLine("\tOne folder limit reached. Delete the folder to add new one. [Enter]");
					Console.ReadLine();
					Menu.Show(Menu.user);
				}
            }
        }

        public static void FolderMenu(string folderTitle)
        {
            Console.Clear();
            Console.WriteLine("\t\t" + folderTitle);
            Console.WriteLine();

            List<string> folderMenu = new List<string>();
            folderMenu.Add("Make a reviewer");
            folderMenu.Add("Flashcards");
            folderMenu.Add("Take a quiz");
			folderMenu.Add("Delete Folder");
            folderMenu.Add("Back");

            for (int i = 0; i < folderMenu.Count; i++)
            {
                Console.WriteLine("\tEnter " + (i + 1) + " to " + folderMenu[i]);
            }

            Console.Write("\tChoose option: ");
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
					Functions.Deletion();
					FolderMenu(folderTitle);
					break;

                case 5:
                    Menu.Show(Menu.user);
                    break;

                default:
                    Console.WriteLine("\tInvalid option. Choose again. [Enter]");
                    Console.ReadLine();
                    FolderMenu(folderTitle); 
                    break;
            }
        }

        public static void ShowFolders()
        {
            if (Folders.Count == 0)
            {
                Console.WriteLine("\tThere is nothing to see here. [Enter]");
                Console.ReadLine();
                Menu.Show(Menu.user); 
            }
            
            else
            {
                Console.Clear();
                Console.WriteLine("\t\tFolders");
                Console.WriteLine();
                Console.WriteLine("\tEnter 1 to Back");
                for (int i = 0; i < Folders.Count; i++)
                {
                    
                    Console.WriteLine("\tEnter " + (i + 2) + " to " + Folders[i]);
                }
                Console.WriteLine("\t------------------------------");

                Console.Write("\tChoose a folder: ");
                int folderOpt = Convert.ToInt32(Console.ReadLine());
                
                switch (folderOpt)
                {
                    case 1:
                    Menu.Show(Menu.user);
                    break;

                    case 2:
                    FolderMenu(Folders[2 - folderOpt]);
                    break;

                    default:
                    Console.WriteLine("\tTry again.[Enter]");
                    Console.ReadLine();
                    ShowFolders();
                    break;
                }
            }
        }
    }
}