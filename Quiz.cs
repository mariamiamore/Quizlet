using System;
namespace Quizlet
{
    internal class Quiz
    {
        public static void Quiziz(Dictionary<string, string> flashcards)
        {
            if (flashcards.Count == 0)
            {
				Console.WriteLine("Make flashcards first. Press Enter to go menu.");
				Console.ReadLine();
                return;
            }
            else
            {
                int score = 0;
                foreach (var flashcard in flashcards)
                {
                    Console.WriteLine("\t" + flashcard.Value);
					Console.Write("Type in term: ");
                    string answer = Console.ReadLine();
                    
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
                Console.WriteLine("Your score is " + score + " out of " + flashcards.Count);
				Console.WriteLine("Press Enter to go menu.");
				Console.ReadLine();
            }
        }
    }
}