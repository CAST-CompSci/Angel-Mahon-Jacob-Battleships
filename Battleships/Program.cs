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
            string[,] hitMatrix = new string[12, 12];

            for (int i = 0; i <= 11; i++)
            {

                for (int j = 0; j <= 11; j++)
                {
                    hitMatrix[i, j] = (" ");
                }
            }

            string u = "0";

            u = Console.ReadLine();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("    A   B   C   D   E   F   G   H   I   J   K   L");
            Console.WriteLine("  ┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
            for (int i = 0; i <= 11; i++)
            {

                if (i < 9) { 
                Console.Write(i + 1);
                Console.Write(" ");
                }
                else
                {
                    Console.Write(i + 1);
                }

                for (int j = 0; j < 12; j++)
                {

                    //System.Threading.Thread.Sleep(20);



                    
                    Console.Write("┃");
                    Console.Write(" " + hitMatrix[i, j] + " ");
                    
                }
                Console.Write("┃");
                Console.WriteLine(" ");
                //Console.ForegroundColor = ConsoleColor.DarkRed;
                if (i < 11)
                {
                    Console.WriteLine("  ┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
                }
                else
                {
                    //Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("  ┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛");
                }
            }
            Console.ReadLine();
        }
    }
}
