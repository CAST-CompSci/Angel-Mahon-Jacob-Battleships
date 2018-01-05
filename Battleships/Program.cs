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

         
                Random generator = new Random();
                int rand = generator.Next(1, 12);
      
                Random generator2 = new Random();
                int rand2 = generator.Next(1, 12);

                hitMatrix[rand, rand2] = "#";
          

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
            Console.Read();
        }
    }
}
