﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain = "";
            do
            {


                Console.WriteLine("Greetings user, and welcome to Katherine and Scott's \"tell-all-ball\" of mystical fortunes~");
                Console.WriteLine("You can quit at any time by typing, \"Quit\" and can Restart at any time by typing, \"Restart\"");

                //FIRST NAME
                Console.WriteLine("Please enter your first name:");
                string firstName = (Console.ReadLine());
                Quit(firstName);
                Restart(firstName);


                //LAST NAME
                Console.WriteLine("Ah yes, " + firstName + ", please enter your last name my child:");
                string lastName = (Console.ReadLine());
                Quit(lastName);
                Restart(lastName);

                //USER AGE
                Console.WriteLine("Please state your current age:");
                string usersAge = (Console.ReadLine());
                Quit(usersAge);
                Restart(usersAge);
                int userAge = int.Parse(usersAge);

                //BIRTH MONTH
                Console.WriteLine("Which month were you born?");
                string birthMonth = Console.ReadLine().ToLower();
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
                Console.WriteLine("How many siblings do you have?");
                string siblings = (Console.ReadLine());
                Quit(siblings);
                Restart(siblings);
                int siblings1 = int.Parse(siblings);

                //RETIREMENT EVEN ODD
                int retirement = 0;
                if (userAge % 2 == 1)
                {
                    retirement = 1;
                }
                else if (userAge % 2 == 0)
                {
                    retirement = 400;
                }

                //VACATION JOINT

                string location = "";

                switch (siblings1)
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


                //MONEY IN DA BANK
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
            while (tryAgain == "yes");
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
        static void Restart(string Reply)
        {
            if (Reply == "Restart")
            {
                var fileName = Assembly.GetExecutingAssembly().Location;
                System.Diagnostics.Process.Start(fileName);
                Environment.Exit(0);
            }
        
    }
    }
}
