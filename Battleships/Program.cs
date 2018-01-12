using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Blue; 
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //^Changes whole console colour and foreground colour now.
            int size = 0;
            string[,] hitMatrix = new string[12, 12];


            for (int i = 0; i <= 11; i++)
            {
                for (int j = 0; j <= 11; j++)
                {
                    hitMatrix[i, j] = (" ");
                }
            }

            int amountofbotes = 5;

            do
            {
                Random generator = new Random();
                int rand = generator.Next(0, 11);

                Random generator2 = new Random();
                int rand2 = generator.Next(0, 11);

                hitMatrix[rand, rand2] = "#";

                Random generator3 = new Random();
                int direction = generator.Next(1, 4);

                //  Random generator4 = new Random();
                //int size = generator.Next(2, 5);


                size = amountofbotes;
                Console.WriteLine("Size" + size);


                if (direction == 1)
                {
                    while (size > 0)
                    {
                        rand = rand + 1;
                        hitMatrix[rand, rand2] = "#";
                        size = size - 1;
                    }
                }
                else if (direction == 2)
                {
                    while (size > 0)
                    {
                        rand = rand - 1;
                        hitMatrix[rand, rand2] = "#";
                        size = size - 1;
                    }
                }
                else if (direction == 3)
                {
                    while (size > 0)
                    {
                        rand2 = rand2 + 1;
                        hitMatrix[rand, rand2] = "#";
                        size = size - 1;
                    }
                }

                else if (direction == 4)
                {
                    while (size > 0)
                    {
                        rand2 = rand2 - 1;
                        hitMatrix[rand, rand2] = "#";
                        size = size - 1;

                    }
                }

                amountofbotes = amountofbotes - 1;
                Console.WriteLine("amount of boats" + amountofbotes);

            } while (amountofbotes >= 0);

                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("    A   B   C   D   E   F   G   H   I   J   K   L");
                Console.WriteLine("  ┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");

                for (int i = 0; i <= 11; i++)
                {
                    if (i < 9)
                    {
                        Console.Write(i + 1);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(i + 1);
                    }
                    for (int j = 0; j < 12; j++)
                    {

                        Console.Write("┃");
                        Console.Write(" " + hitMatrix[i, j] + " ");
                    }

                    Console.Write("┃");
                    Console.WriteLine(" ");

                    if (i < 11)
                    {
                        Console.WriteLine("  ┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
                    }
                    else
                    {
                        Console.WriteLine("  ┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛");
                    }

                }
                Console.Read();
            
        }
    }
}
