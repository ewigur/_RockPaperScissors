using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _RockPaperScissors
{
    internal class function
    {

        static void Main(string[] args)
        {
            //StartWallet
            int pMoney = 100;
            int cMoney = 100;

            //Bets
            int lowestBet = 1;
            int pBet = 0;
            int cBet = 0;

            //Welcome_message
            Console.WriteLine("You've been invited to play Rock, Paper, Scissors. Your current wallet has a value of 100, place your bet and make your choice - Rock, paper or scissors...");

            //Function_call           
            _gameLoop();
            _emptyWallet();

            void _gameLoop()
            {
                Random generator = new Random();
                Random rnd = new Random();

                //Rock_paper_scissors?
                int pChoice = 0;
                int cChoice = 0;

                int rock = 1;
                int paper = 2;
                int scissors = 3;

                while (pMoney > 0 && cMoney > 0)
                {
                    //Betting
                    Console.WriteLine("Your current wallet has a value of " + pMoney + ", computer wallet is " + cMoney + ".");
                    Console.WriteLine("Place your bet...");
                    pBet = Convert.ToInt32(Console.ReadLine());
                    cBet = rnd.Next(lowestBet, cMoney);

                    //Invalid_bet
                    if (pBet == 0)
                    {
                        Console.WriteLine("You can't bet that low, try again...");
                        continue;

                    }

                    if (pBet > pMoney)
                    {
                        Console.WriteLine("You can't bet that high, try again...");
                        continue;

                    }

                    else
                    {
                        string bet = pBet.ToString();
                        Console.WriteLine("You've placed a bet with a value of: " + pBet + " , the computer has placed a bet with the value of " + cBet);

                    }

                    Console.WriteLine("Choose your weapon - rock = 1, paper = 2, or scissors = 3...");

                    pChoice = Convert.ToInt32(Console.ReadLine());

                    cChoice = rnd.Next(1, 4);

                    //Invalid_weapon
                    if (pChoice > 3)
                    {
                        Console.WriteLine("You can only choose 1,2 or 3");
                        continue;
                    }

                    switch (cChoice)
                    {
                        case 1:
                            //Cchoice_Rock
                            if (pChoice == 1)
                            {
                                //Tie
                                Console.WriteLine("You chose Rock");
                                Console.WriteLine("Computer chose Rock");
                                Console.WriteLine("It is a tie, no money was lost.");
                            }

                            else if (pChoice == 2)
                            {
                                Console.WriteLine("You chose Paper");
                                Console.WriteLine("Computer chose Rock");
                                Console.WriteLine("You win");
                                pMoney = pMoney + cBet;
                                cMoney = cMoney - cBet;

                            }
                            else if (pChoice == 3)
                            {
                                Console.WriteLine("You chose Scissors");
                                Console.WriteLine("Computer chose Rock");
                                Console.WriteLine("Computer wins");
                                pMoney = pMoney - pBet;
                                cMoney = cMoney + pBet;

                            }
                            break;

                        case 2:
                            //Cchoice_Paper
                            if (pChoice == 1)
                            {
                                //Tie
                                Console.WriteLine("You chose Rock");
                                Console.WriteLine("Computer chose Rock");
                                Console.WriteLine("It is a tie, no money was lost.");
                            }

                            else if (pChoice == 2)
                            {
                                Console.WriteLine("You chose Paper");
                                Console.WriteLine("Computer chose Rock");
                                Console.WriteLine("You win");
                                pMoney = pMoney + cBet;
                                cMoney = cMoney - cBet;

                            }
                            else if (pChoice == 3)
                            {
                                Console.WriteLine("You chose Scissors");
                                Console.WriteLine("Computer chose Rock");
                                Console.WriteLine("Computer wins");
                                pMoney = pMoney - pBet;
                                cMoney = cMoney + pBet;

                            }
                            break;

                        case 3:
                            //cChoice_Scissor
                            if (pChoice == 1)
                            {

                                //Tie
                                Console.WriteLine("You chose Rock");
                                Console.WriteLine("Computer chose Scissors");
                                Console.WriteLine("You win.");
                                pMoney = pMoney + cBet;
                                cMoney = cMoney - cBet;

                            }

                            else if (pChoice == 2)
                            {
                                Console.WriteLine("You chose Paper");
                                Console.WriteLine("Computer chose Scissors");
                                Console.WriteLine("Computer wins");
                                pMoney = pMoney - pBet;
                                cMoney = cMoney + pBet;

                            }
                            else if (pChoice == 3)
                            {
                                Console.WriteLine("You chose Scissors");
                                Console.WriteLine("Computer chose Scissors");
                                Console.WriteLine("It is a tie, no money was lost.");
                            }
                            break;
                    }
                }
                return;
            }

            void _emptyWallet()
            {

                while (true)
                {
                    //Empty_wallet
                    if (pMoney > 1)
                    {
                        Console.WriteLine("Your wallet is empty. Game over!");
                        break;
                    }

                    else if (cMoney > 1)
                    {
                        Console.WriteLine("Your opponents wallet is empty. You've won!");
                        break;
                    }
                    return;
                }
            }
        }
    }
}