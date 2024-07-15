using System;

namespace Quizlet
{
    internal class Functions
    {
		public static void Deletion()
		{
			Console.WriteLine("\tDeleting...");
			Folder.Folders.Clear();
			Console.WriteLine("\tDeleted Successfully.");
			Console.ReadLine();
			Menu.Show(Menu.user);
		}
		
		public static void AddingFolder()
		{
			Console.Clear();
			Console.WriteLine("\tAdd Folder");
			Folder.AddFolder();
		}
		
		public static void FolderList()
		{
			Console.Clear();
			Console.WriteLine("\t\tFOLDERS");
			Folder.ShowFolders();
		}
		
        public static void MakingReviewer()
        {
            
            Reviewer.MakeReviewer();
        }

        public static void FlashCards()
        {
			Console.Clear();
            Console.WriteLine("\tReviewing the Flashcards");
            Flashcards.flashcard(Reviewer.flashcards);
        }

        public static void TakingQuiz()
        {
			Console.Clear();
            Console.WriteLine("\tPreparing Quiz...");
            Quiz.Quiziz(Reviewer.flashcards);
        }

        public static void Signout()
        {
			Console.Clear();
            Console.WriteLine("\tSigning out...");
			Program.Welcome();
        }
    }
}