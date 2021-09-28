using System;
using System.Threading;

/*
             *REQUIREMENTS:
             * 1) Ask the user for a yes or no question
             * 2) Respond with a random answer from a set (collection) of answers
             * 3) Set the program to loop based on a user's choice (Do you want to ask another question?)
             * HINTS: Code will run at least once, then an unkown # of times afterwards
             * HINTS: You call an item from a collection by an index fruit[2] -> fruits[x]
             */


namespace _2Tuesday
{
    //abstract class Amber
    //{
    //  private static string name = "Amber";
    //  public static string alias = "AmberMeals";
    //  private static int age = 29;
    //}//END NAMECLASS experiment 


    /// <summary>
    /// Entry point for Magic 8 Ball Program by Amber
    /// </summary>


    class Magic8Ball
    {
        static void Main(string[] args)
        {
            Console.Title = "====== Magic 8 Ball =======";
            //preserve current text color
            ConsoleColor oldColor = Console.ForegroundColor;

            //experimenting with making methods
            TellPpleWhatProgramThisIs();

            //create a randomizer object - initiating random
            Random randomObject = new Random();


            //Loop FOREVVVVVVVVVVVEEEEERRRR EEREEEEEEEEEERRRRRRRR-keep asking questions
            while (true)
            {                           //not necessary (), experiementing with cleaner code
                string questionString = GetQuestionFromUser();

                int numOfSeconds = randomObject.Next(5) + 1;
                Console.WriteLine("hang tight, deciding your fate mortal...");
                //had to do math conversaion into actual seconds from milli seconds
                Thread.Sleep(numOfSeconds * 1000);

                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to type a question idiot...");
                    continue;//don't run anymore code in that loop, go back to the beginning and start again
                }

                //See if the user typed 'end'
                if (questionString.ToLower() == "end")
                {
                    break;
                }//end ifelse

                //added humor, if user says 'you suck', 8 ball prog will reply
                if (questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("trust me, your future will suck more....bye");
                    break;
                }//end ifelse
                
                //Get a random number
                int randNumb = randomObject.Next(5);

                //changing font color on case answers
                Console.ForegroundColor = (ConsoleColor)randNumb;
                //Use random number to determine response
                switch (randNumb)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!!!");
                        }
                        break;
                    case 1:
                        {
                            Console.WriteLine("NO");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("HECK NO");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("....snoozing ask again later.....");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("the answer is always 42.....");
                        }
                        break;

                }//endSwitch
            }//endWhile



        }//END MAIN


        /// <summary>
        /// This will print name of program & who created it to the console
        /// </summary>
        static void TellPpleWhatProgramThisIs()
        {
            //change console text color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Magic 8 Ball");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" by: Amber ");

        }//end experimentnameMethod

        /// <summary>
        /// This function will return the text the user types
        /// </summary>
        /// <returns></returns>
        static string GetQuestionFromUser()
        {

            //This block of code will ask the user for a question
            //store the info in questionString variable
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.White;
            string questionString = Console.ReadLine();

            return questionString;

        }//end GetQuestion()



    }//END CLASS
}//END NAMESPACE
