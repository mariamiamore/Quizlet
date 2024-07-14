using System;
using System.Collections.Generic;

namespace Quizlet
{
    internal class Reviewer
    {
        public static Dictionary<string, string> flashcards = new Dictionary<string, string>();

        public static void MakeReviewer()
        {
            string term = "";
            string def = "";

            while (true)
            {
                Console.WriteLine("Enter 1 to Done");
                Console.WriteLine("Enter 2 to Add");
                Console.Write("Choose an Option: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice== "1")
                {
                    return;
                }
                else if (choice == "2")
                {
                    Console.Write("Enter a term: ");
                    term = Console.ReadLine();
                    Console.Write("Enter the definition: ");
                    def = Console.ReadLine();

                    flashcards.Add(term, def);

                    Console.WriteLine("Creating Flashcards...");
                    Console.WriteLine("Flashcards created successfully");
                    Console.WriteLine(" ");

                    foreach (var flashcard in flashcards)
                    {
                        Console.WriteLine("Term: " + flashcard.Key);
                        Console.WriteLine("Definition: " + flashcard.Value);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Choose again. [Enter]");
                    Console.ReadLine();
                }
            }
        }
    }
}