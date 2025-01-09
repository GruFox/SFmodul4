using System.ComponentModel.Design;

namespace Modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string A;
            string B;
            bool C = A != B;*/

            /*int A;
            int B;
            double X;
            double Y;
            bool C = (A < B) | (X > Y);*/

            int t = 0;

            while (true)
            {
                Console.WriteLine(t);
                Console.Write("Напишите свой любимый цвет на английском с маленькой буквы: ");

                var text = Console.ReadLine();

                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }

                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        //Console.BackgroundColor = ConsoleColor.Yellow;
                        //Console.ForegroundColor = ConsoleColor.Red;

                        //Console.WriteLine("Your color is yellow!");
                        //break;
                        continue;
                }
                t++;
            }
            

            

        }
    }
}
