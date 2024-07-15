using System;
namespace Quizlet
{
    internal class Quiz
    {
        public static void Quiziz(Dictionary<string, string> flashcards)
        {
			Console.WriteLine("\t\tQUIZ");
            if (flashcards.Count == 0)
            {
				Console.WriteLine("\tMake flashcards first. Press Enter to go menu.");
				Console.ReadLine();
                return;
            }
            else
            {
                int score = 0;
                foreach (var flashcard in flashcards)
                {
                    Console.WriteLine("\t\t" + flashcard.Value);
					Console.Write("\tType in term: ");
                    string answer = Console.ReadLine();
					Console.WriteLine("\t------------------------------");
                    
                    if (answer.ToLower() == flashcard.Key.ToLower())
                    {
                        score++;
                    }
                    else
                    {
                        score = score + 0;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("\tYour score is " + score + " out of " + flashcards.Count);
				Console.WriteLine("\tPress Enter to go menu.");
				Console.ReadLine();
            }
        }
    }
}