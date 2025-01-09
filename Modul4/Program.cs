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

            Console.Write("Напишите свой любимый цвет на английском с маленькой буквы: ");
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            

        }
    }
}
