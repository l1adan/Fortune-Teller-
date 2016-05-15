using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection; //required for restart method to work
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain = "";
            do // created do while loop - to run fortune teller program and ask user to play again or quit upon completing the app.
            {
                Console.WriteLine("Greetings,");
                Console.WriteLine("and welcome to Katherine and Scotts \"tell-all-ball\" of mystical fortunes~");
                Console.WriteLine("You may quit by typing, \"Quit\" and Restart, by typing, \"Restart\"");

                Console.WriteLine();

                //FIRST NAME
                Console.WriteLine("Please enter your first name:");
                string firstName = (Console.ReadLine());
                Console.WriteLine();
                Quit(firstName);
                Restart(firstName);


                //LAST NAME
                Console.WriteLine("Ah yes, " + firstName + ", please enter your last name my child:");
                string lastName = (Console.ReadLine());
                Console.WriteLine();
                Quit(lastName);
                Restart(lastName);

                //USER AGE
                
                int ageNum = 0;
                //ensure user enters a valid number (not a string)
                do
                {
                    try
                    {
                        Console.WriteLine("Please enter your current age:");
                        string usersAge = Console.ReadLine();
                        Console.WriteLine();
                        Quit(usersAge);
                        Restart(usersAge);
                        ageNum = int.Parse(usersAge);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid answer!");
                    }
                }
                while (ageNum == 0);
               

                //BIRTH MONTH
                Console.WriteLine("Which month were you born?");
                string birthMonth = Console.ReadLine().ToLower();
                Console.WriteLine();
                Quit(birthMonth);
                Restart(birthMonth);

                //FAV COLOR
                string favoriteColor = "";
                do
                {
                    Console.WriteLine("Please enter your favorite ROYGBIV color:");
                    Console.WriteLine("(Not sure what ROYGBIV means? Type \"Help\".)");
                    favoriteColor = Console.ReadLine().ToLower();
                    if (favoriteColor == "HELP")
                    {
                        Console.WriteLine("Red\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet");
                    }
                }
                while (favoriteColor == "HELP");



                //SIBLINGS
               
                int siblingsNum = -1;
                do
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("How many siblings do you have?");
                        string userSiblings = Console.ReadLine();
                        Quit(userSiblings);
                        Restart(userSiblings);
                        siblingsNum = int.Parse(userSiblings);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid answer!");
                    }
                }
                while (siblingsNum == -1);
               

                //RETIREMENT EVEN / ODD
                int retirement = 0;
                if (ageNum % 2 == 1)
                {
                    retirement = 1;
                }
                else if (ageNum % 2 == 0)
                {
                    retirement = 400;
                }

                //VACATION LOCATION

                string location = "";

                switch (siblingsNum)
                {
                    case 0:
                        location = " in The Closet";
                        break;

                    case 1:
                        location = " in Narnia";
                        break;

                    case 2:
                        location = " in Hogsmede";
                        break;

                    case 3:
                        location = " in Laguna beach";
                        break;

                    default:
                        location = " in The Moon";
                        break;
                }

                //TRANSPORTATION
                string transportation = "";

                switch (favoriteColor)
                {
                    case "red":
                        transportation = " a pimmped out riding lawn moer "; 
                        break;

                    case "orange":
                        transportation = " a pick up truck";
                        break;

                    case "yellow":
                        transportation = " a wild Pikachu ";
                        break;


                    case ("green"):
                        transportation = " a leprecauhn ";
                        break;

                    case ("blue"):
                        transportation = " a tiger ";
                        break;

                    case ("indigo"):
                        transportation = " a unicycle ";
                        break;

                    case ("violet"):
                        transportation = " a skateboard ";
                        break;

                    default:
                        transportation = " a spaceship";
                        break;

                }


                //MONEY IN BANK
                // compares indices of first and last name to letters with in the users birthMonth
                char firstLetter = birthMonth[0];
                char secondLetter = birthMonth[1];
                char thirdLetter = birthMonth[2];
                string moneyInBank = "";
                if (firstName.IndexOf(firstLetter) != -1 || lastName.IndexOf(firstLetter) != -1)
                {
                    moneyInBank = "100.00";
                }
                else if (firstName.IndexOf(secondLetter) != -1 || lastName.IndexOf(secondLetter) != -1)
                {
                    moneyInBank = "500.00";
                }
                else if (firstName.IndexOf(thirdLetter) != -1 || lastName.IndexOf(thirdLetter) != -1)
                {
                    moneyInBank = "10,000";
                }
                else
                {
                    moneyInBank = "3.00";
                }

                // fortune output
                Console.WriteLine("\a\a\a" + firstName + " " + lastName + " will retire in " + retirement + " years. You will have $" + moneyInBank + " in the bank, a vacation home " + location + " and your mode of transportation will be" + transportation + ".");




                
                Console.WriteLine("If you would like to try again, write \"yes\". If not, write \"no\" ");
                tryAgain = Console.ReadLine();
            }
            while (tryAgain == "yes"); // end of do while
        }



        static void Quit(string userReply)
        {
            userReply = userReply.ToUpper();

            if (userReply == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);

            }



        }
        static void Restart(string Reply) // creating a restart method
        {
            if (Reply == "Restart")
            {
                var fileName = Assembly.GetExecutingAssembly().Location;  //gets the document location of fortune teller file
                System.Diagnostics.Process.Start(fileName);               // starts new fortune telling game
                Environment.Exit(0);        
            }
        
    }
    }
}
