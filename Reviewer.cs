using System;


namespace Quizlet
{
    internal class Reviewer
    {
        public static Dictionary<string, string> flashcards = new Dictionary<string, string>();
		public static string folderTitle = "";
		static string term = "";
        static string def = "";
		
        public static void MakeReviewer()
        {
            while (true)
            {
				Console.Clear();
				Console.WriteLine("\t    Reviewer...");
                Console.WriteLine("\tEnter 1 to Done");
                Console.WriteLine("\tEnter 2 to Add");
                Console.Write("\tChoose an Option: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice== "1")
                {
                    return;
                }
                else if (choice == "2")
                {
					Console.Clear();
						Console.WriteLine("\t\tNOTE: THE TERM MUST NOT BE REPEATED");
						Console.Write("\tEnter a term: ");
						term = Console.ReadLine();
						Console.Write("\tEnter the definition: ");
						def = Console.ReadLine();
						flashcards.Add(term, def);

                    Console.WriteLine("\tCreating Flashcards...");
                    Console.WriteLine("\tFlashcards created successfully [Enter]");
                    Console.ReadLine();

                    foreach (var flashcard in flashcards)
                    {
                        Console.WriteLine("\tTerm: " + flashcard.Key);
                        Console.WriteLine("\tDefinition: " + flashcard.Value);
                        Console.WriteLine();
                    }	
                }
                else
                {
                    Console.WriteLine("\tInvalid option. Choose again. [Enter]");
                    Console.ReadLine();
                }	
            }
        }
    }
}
