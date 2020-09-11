using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 100;
            //  Console.BufferHeight = 100;
            Console.SetWindowSize(Console.BufferWidth, 58);

            bool playAgain = false;

            //Play again do-loop
            do
            {
                bool repeat = false;
                bool gameWon = false;

                Console.WriteLine("");
                Console.WriteLine("");

                graphic2();

                int x = 0;
                int z = 1;


                int[] arrayQ = new int[4];

                Console.WriteLine("");
                Console.WriteLine("");

                // Repeat do-loop for Question Array
                do
                {
                    Console.WriteLine("Please enter the Question colors: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    x = num1;



                    //Question ARRAY input
                    for (int i = 3; i >= 0; i--)
                    {
                        arrayQ[i] = x % 10;
                        x = x / 10;
                    }


                    //Repetation Check for Question Array

                    if (arrayQ[3] == arrayQ[2] || arrayQ[3] == arrayQ[1] || arrayQ[3] == arrayQ[0])
                    {
                        repeat = true;
                    }

                    else if (arrayQ[2] == arrayQ[1] || arrayQ[2] == arrayQ[0])
                    {
                        repeat = true;
                    }

                    else if (arrayQ[1] == arrayQ[0])
                    {
                        repeat = true;
                    }

                    else repeat = false;

                    if (repeat == true)
                        Console.WriteLine("Invalid Input : Please do not repeat any colors");


                } while (repeat == true);




                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("");

                graphic2();

                Console.WriteLine("");
                Console.WriteLine("");


                //repeat = false;
                while (gameWon == false)
                {

                    int y = 0;

                    int[] arrayA = new int[4];

                    // Repeat do-loop for Answer Array
                    do
                    {

                        y = Convert.ToInt32(Console.ReadLine());




                        //Answer ARRAY input
                        for (int i = 3; i >= 0; i--)
                        {
                            arrayA[i] = y % 10;
                            y = y / 10;
                        }


                        //Repeatition Check for Answer Array
                        if (arrayA[3] == arrayA[2] || arrayA[3] == arrayA[1] || arrayA[3] == arrayA[0])
                        {
                            repeat = true;
                        }

                        else if (arrayA[2] == arrayA[1] || arrayA[2] == arrayA[0])
                        {
                            repeat = true;
                        }

                        else if (arrayA[1] == arrayA[0])
                        {
                            repeat = true;
                        }

                        else repeat = false;

                        if (repeat == true)
                            Console.WriteLine("Invalid Input : Please do not repeat any colors");



                    } while (repeat == true);


                    //Input Colors DISPLAYED
                    for (int i = 0; i <= 3; i++)
                    {
                        int t = arrayA[i];
                        switch (t)
                        {
                            case 1:
                                Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("   ");
                                Console.ResetColor();
                                Console.Write(" ");
                                break;
                            case 2:
                                Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("   ");
                                Console.ResetColor();
                                Console.Write(" ");
                                break;
                            case 3:
                                Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("   ");
                                Console.ResetColor();
                                Console.Write(" ");
                                break;
                            case 4:
                                Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("   ");
                                Console.ResetColor();
                                Console.Write(" ");
                                break;
                            case 5:
                                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("   ");
                                Console.ResetColor();
                                Console.Write(" ");
                                break;
                            case 6:
                                Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("   ");
                                Console.ResetColor();
                                Console.Write(" ");
                                break;
                            case 7:
                                Console.BackgroundColor = ConsoleColor.Magenta; Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("   ");
                                Console.ResetColor();
                                Console.Write(" ");
                                break;
                        }

                    }


                    //point system
                    int pink = 0, white = 0;

                    for (int i = 0; i <= 3; i++)
                    {
                        if (arrayQ[i] == arrayA[i])
                            pink++;

                        if (arrayQ[0] == arrayA[i])
                            white++;

                        if (arrayQ[1] == arrayA[i])
                            white++;

                        if (arrayQ[2] == arrayA[i])
                            white++;

                        if (arrayQ[3] == arrayA[i])
                            white++;
                    }



                    white = white - pink;

                    Console.Write("                                           ");


                    //Points DISPLAYED
                    for (int i = 1; i <= white; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("II");
                        Console.ResetColor();
                        Console.Write(" ");
                    }

                    for (int i = 1; i <= pink; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("II");
                        Console.ResetColor();
                        Console.Write(" ");
                    }


                    Console.ResetColor();



                    Console.WriteLine();
                    Console.WriteLine();

                    //Win Check
                    if (pink == 4 && z != 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("CONGRATULATION YOU WON THE GAME IN " + z + " Rounds!");
                        gameWon = true;


                    }

                    //Win Check First Round
                    else if (pink == 4 && z == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("CONGRATULATION YOU WON THE GAME IN THE FIRST Round!");
                        gameWon = true;


                    }

                    z++;
                }






            Console.WriteLine("Do you want to play again? (Y/N) ?");

            string reply = Console.ReadLine().ToUpper();

                if (reply == "Y")
                    playAgain = true;

                else if (reply == "N")
                    playAgain = false;

                else
                    Console.WriteLine("Please enter a valid input");




            } while (playAgain = true); // play again do-loop END






            Console.WriteLine("Thank you for playing Mastermind! :D");









            void graphic2()
            {
                Console.WriteLine("  __  __               _____   _______   ______   _____    __  __   _____   _   _   _____  ");
                Console.WriteLine(" |  \\/  |     /\\      / ____| |__   __| |  ____| |  __ \\  |  \\/  | |_   _| | \\ | | |  __ \\ ");
                Console.WriteLine(" | \\  / |    /  \\    | (___      | |    | |__    | |__) | | \\  / |   | |   |  \\| | | |  | |");
                Console.WriteLine(" | |\\/| |   / /\\ \\    \\___ \\     | |    |  __|   |  _  /  | |\\/| |   | |   |     | | |  | |");
                Console.WriteLine(" | |  | |  / ____ \\   ____) |    | |    | |____  | | \\ \\  | |  | |  _| |_  | |\\  | | |__| |");
                Console.WriteLine(" |_|  |_| /_/    \\_\\ |_____/     |_|    |______| |_|  \\_\\ |_|  |_| |_____| |_| \\_| |_____/ ");

            }

            void graphic3()
            {
                Console.WriteLine(@"  __  __               _____   _______   ______   _____    __  __   _____   _   _   _____  ");
                Console.WriteLine(@" |  \/  |     /\      / ____| |__   __| |  ____| |  __ \  |  \/  | |_   _| | \ | | |  __ \ ");
                Console.WriteLine(@" | \  / |    /  \    | (___      | |    | |__    | |__) | | \  / |   | |   |  \| | | |  | |");
                Console.WriteLine(@" | |\/| |   / /\ \    \___ \     | |    |  __|   |  _  /  | |\/| |   | |   |     | | |  | |");
                Console.WriteLine(@" | |  | |  / ____ \   ____) |    | |    | |____  | | \ \  | |  | |  _| |_  | |\  | | |__| |");
                Console.WriteLine(@" |_|  |_| /_/    \_\ |_____/     |_|    |______| |_|  \_\ |_|  |_| |_____| |_| \_| |_____/ ");

            }


        }


    }
}
