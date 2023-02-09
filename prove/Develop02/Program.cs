using System;
using System.IO;

class program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your Journal");
        // Declare all of my variables
        int menuOption = 0;
        DateTime myTimeStamp = new DateTime();
        var listDisplay = new List<string>();

        Console.WriteLine("Please select an option listed below by the number listed");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        //you need to validate the user entered a number etc.  data scrub
        int menuOption = Convert.ToInt32(Console.ReadLine());


        switch(menuOption)
        {
            case 1:
                //this is menu option 1
                //ask a random question
                Console.WriteLine("Please write an entry");
                string prompt = askQuestion();
                Console.WriteLine(prompt);
                string entry = Console.ReadLine();
                break;
            case 2:
                //display
                Console.Clear() //clear at start to mak it easier to read
                Console.WriteLine("all journal entries \r\n");
                foreach(var allEntry in listDisplay)
                {
                    Console.WriteLine(allEntry);
                }
                break;
            case 3:
            // load
                break;
            case 4:
                //save
                journalPath = findingJournal();

                break;
            case 5:
            //quit
                break;
            default:
                break;
        }
        
        //asking a random question
        static string askQuestion()
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,6);
            string myQuestion = "";
            switch (magicNumber)
                {
                    case 1:
                    myQuestion = "Who was the most interesting person I interacted with today?";
                    break;
                    case 2:
                    myQuestion = "What was the best part of my day?";
                    break;
                    case 3:
                    myQuestion = "How did I see the hand of the Lord in my life today?";
                    break;
                    case 4:
                    myQuestion = "What was the strongest emotion I felt today?";
                    break;
                    case 5:
                    myQuestion = "If I had one thing I could do over today, what would it be?";
                    break;


                }
            return myQuestion;
            
        }
    }
    static string findingJournal()
    {
        
    }
}