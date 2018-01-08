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

            string[,] hitMatrix = new string[12, 12];

            for (int i = 0; i <= 11; i++)
            {
                for (int j = 0; j <= 11; j++)
                {
                    hitMatrix[i, j] = ("#");
                }
            }

            Console.OutputEncoding = Encoding.UTF8;
          
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
                    System.Threading.Thread.Sleep(2);
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
            Console.ReadLine();
        }
    }
}
