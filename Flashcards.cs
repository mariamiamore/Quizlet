using System;
namespace Quizlet
{
    internal class Flashcards
    {
        public static void flashcard(Dictionary<string, string> flashcards)
        {
			Console.WriteLine("\t\tFLASHCARDS");
            if (flashcards.Count == 0)
            {
				Console.WriteLine("\tNo flashcards added yet. Press Enter to go menu.");
                Console.ReadLine();
            }
            else 
            {
				int count = 1;
                foreach (var flashcard in flashcards)
                {
                    Console.WriteLine("\t\tFlashcard "+ count);
                    Console.WriteLine("\tTerm: " + flashcard.Key);
                    Console.Write("\tPress Enter to see the definition...");
                    Console.ReadLine();
                    Console.WriteLine("\tDefinition: " + flashcard.Value);
					Console.WriteLine("\t------------------------------");
                    Console.ReadLine();
                    count++;
                }
                Console.WriteLine("\tYou're going back to the menu. [Enter]");
                Console.ReadLine();
            }
		}
    }
}
