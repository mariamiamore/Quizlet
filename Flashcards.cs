using System;
namespace Quizlet
{
    internal class Flashcards
    {
        
        public static void flashcard(Dictionary<string, string> flashcards)
        {
            if (flashcards.Count == 0)
            {
                Console.WriteLine("No flashcards added yet. Press Enter to go menu.");
                Console.ReadLine();
            }
            else
            {
                int count = 1;
                foreach (var flashcard in flashcards)
                {
                    Console.WriteLine("Flashcard "+ count);
                    Console.WriteLine("Term: " + flashcard.Key);
                    Console.Write("Press Enter to see the definition...");
                    Console.ReadLine();
                    Console.WriteLine("Definition: " + flashcard.Value);
                    Console.ReadLine();
                    count++;
                }
                Console.WriteLine("You're going back to the menu. [Enter]");
                Console.ReadLine();
            }
            
        }
    }
}