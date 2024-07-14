using System;

namespace Quizlet
{
    internal class Functions
    {
        public static void MakingReviewer()
        {
            Console.WriteLine("Moving to a Reviewer...");
            Reviewer.MakeReviewer();
        }

        public static void FlashCards()
        {
            Console.WriteLine("Reviewing the Flashcards");
            Flashcards.flashcard(Reviewer.flashcards);
        }

        public static void TakingQuiz()
        {
            Console.WriteLine("Preparing Quiz...");
            Quiz.Quiziz(Reviewer.flashcards);
        }

        public static void Signout()
        {
            Console.WriteLine("Signing out...");
			Program.Welcome();
        }
        
    }
    
}