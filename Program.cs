using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace Outguess {
    internal class Program {
        static void Main(string[] args) {
            //MAIN CODE GOES HERE

            //DECLARE VARIABLES
            double numberUser = 0;
            double cashUser   = 0;
            double wagerUser  = 0;
            double guessUser  = 0;
            double answer     = 0;
            double cashTotal  = 0;
            int win           = 0;

            //RANDOM NUMBER GENERATOR
            Random rndmaker = new Random();
            answer = rndmaker.Next(1, 101);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELCOME TO OUTGUESS!");
            Console.ResetColor();

            Console.WriteLine("I've chosen a secret number from 1 to 100. Want to guess the right number? Lets gamble!");
            Console.WriteLine("How much total cash are you bringing?");
            Console.Write("Cash: $");

            Console.ForegroundColor = ConsoleColor.Blue;
            cashUser  = double.Parse(Console.ReadLine());
            Console.ResetColor();

            cashTotal = cashUser;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"${cashTotal} in the bank!");
            Console.ResetColor();
            Console.WriteLine("");

            Console.WriteLine("How much cash do you want to wager?");
            Console.Write("Wage: $");

            Console.ForegroundColor = ConsoleColor.Blue;
            wagerUser = double.Parse(Console.ReadLine());
            Console.ResetColor();

            //WHILE
            bool CONTINUE = true;

            while (CONTINUE) {

                do {
                    Console.WriteLine("How many guesses do you think it will take for you to get the number right? Let's not pick over 10.");
                    Console.Write("Guess: ");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    guessUser = double.Parse(Console.ReadLine());
                    Console.ResetColor();

                    //GUESS CHECK
                    if (guessUser < 11 && guessUser > 0 && cashUser > 0) {
                        Console.WriteLine("Alright! Here we go! If you dont guess it in time I'm taking some of your cash ;)");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine("GAME START!");
                        Console.ResetColor();
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry I can't work with that number!");
                        Console.ResetColor();
                    }  
                } while (guessUser > 11 || guessUser < 0);
                   
                //GUESSING TIME
                for (double guess = guessUser; guess > 0; guess--) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please pick a number from 1 to 100! :");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    numberUser = double.Parse(Console.ReadLine());
                    Console.ResetColor();

                    if (numberUser == answer) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct number! You win!");
                        win++;
                        Console.WriteLine($"Win Count: {win}");
                        Winnings(guessUser, wagerUser, cashUser, cashTotal);
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"${cashTotal} in the bank now!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        guess = 0;
                    } 
                    else if (numberUser < answer) 
                    {
                        Console.WriteLine($"Number too low!  Guesses left: {guess - 1}");
                        Console.WriteLine("");
                    } 
                    else if (numberUser > answer) 
                    {
                        Console.WriteLine($"Number too high! Guesses left: {guess - 1}");
                        Console.WriteLine("");
                    }//END IF
                }//END FOR: GUESSING TIME
               


                //RAN OUT OF GUESSES!
                if (numberUser != answer) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, you're all out of guesses! The correct number was {answer}!");
                    Losings(guessUser, wagerUser, cashUser, cashTotal);
                    Console.ResetColor();

                //RAN OUT OF MONEY!
                } 
                else if (cashTotal < 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry you have no more money to play!");
                    Console.ResetColor();
                    Losings(guessUser, wagerUser, cashUser, cashTotal);

                //RAN OUT OF GUESSES AND CASH!
                } else if (numberUser != answer && cashTotal! > 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're out of guesses and cash! You can't play any further.");
                    Console.ResetColor();
                    Losings(guessUser, wagerUser, cashUser, cashTotal);
                }//END ELSE IF


                //PLAYER CONTINUE???
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("CONTINUE?");
                Console.WriteLine("  y / n  ");
                Console.ResetColor();
                CONTINUE = Console.ReadKey(true).KeyChar.ToString().ToLower() == "y";
                Console.WriteLine("");
            }//END WHILE


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("THANKS FOR PLAYING OUTGUESS!");
            Console.ResetColor();


        static double Winnings(double guessWin,double wagerWin, double cashWin, double cashWinTotal) {

                if (guessWin == 1) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 10);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 2) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 9);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 3) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 8);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 4) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 7);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 5) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 6);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 6) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 5);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 7) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 4);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 8) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 3);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 9) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 2);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                else if (guessWin == 10) {
                    cashWinTotal = cashWin + (guessWin = wagerWin * 1);
                    Console.WriteLine($"You got ${guessWin}!");
                }
                return wagerWin;
                return cashWin;
                return cashWinTotal;
            }//END Winnings FUNCTION

        static double Losings(double guessLose, double wagerLose, double cashLose, double cashLoseTotal) {

                if (guessLose == 1) {
                    guessLose = wagerLose / 10;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } else if (guessLose == 2) {
                    guessLose = wagerLose / 9;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 3) {
                    guessLose = wagerLose / 8;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 4) {
                    guessLose = wagerLose / 7;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 5) {
                    guessLose = wagerLose / 6;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 6) {
                    guessLose = wagerLose / 5;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 7) {
                    guessLose = wagerLose / 4;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 8) {
                    guessLose = wagerLose / 3;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 9) {
                    guessLose = wagerLose / 2;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                } 
                else if (guessLose == 10) {
                    guessLose = wagerLose / 1;
                    cashLoseTotal = cashLose - guessLose;
                    Console.WriteLine($"You got ${guessLose}!");
                }
                return wagerLose;
            }//END Losings FUNCTION
        }//END MAIN
    }//END CLASS
}//END NAMESPACE