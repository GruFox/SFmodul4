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



            /*int t = 0;

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
            }*/



            /*Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            foreach (var wordsInName in name)
            {
                Console.Write(wordsInName + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Последняя буква вашего имени: " + name[name.Length - 1]);

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }*/




            /*int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                {
                    Console.Write(array[k, i] + " ");
                }

                Console.WriteLine();
            }*/




            /*var arr = new[] { 5, 6, 9, 1, 2, 3, 4 };
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length + 1; i++)
            {
                int b = arr[i];

                foreach (var number in arr2)
                {
                    if (number > arr2[i])
                    {
                        continue;
                    } else
                    {
                        arr2[i] = b;
                    }
                }

            }
            Console.Write(arr2);*/




            /*Console.WriteLine("Введите 3 своих любимых цвета:");
            string[,] favcolors = new string[,] { { "color1" }, { "color2" }, { "color3" } };
            var t = 0;
            var n = 1;
            while (true)
            {
                if (n > 3)
                {
                    Console.WriteLine("Вы ввели требуемое количество цветов!");
                    break;
                }
                Console.WriteLine("Введите свой любимый цвет номер " + n);
                string inter = Console.ReadLine();
                if (inter == "stop")
                {
                    Console.WriteLine("Цикл остановлен!");
                    break;
                }   else
                {
                    favcolors[t, 0] = inter;
                }

                t++;
                n++;
            }

            foreach (var color in favcolors)
            {
                foreach (var item in color)
                {
                    Console.Write(item + " ");
                }
            }*/




            /*int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Четные числа массива: ");

            foreach (int p in arr)
            {
                int ost = p % 2;
                if (ost == 0) Console.Write(p + " ");

                //else continue;
            }
            Console.WriteLine();
            Console.WriteLine("Перебор окончен");*/





            /*int[] array = { -10, 9, -8, 7, -6, 5, -4, 3, -2, 1, 0 };
            int numbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    numbers++;
            }

            Console.WriteLine(numbers);*/




            /*int[][] array = [ [ -10, 9, -8, 7, -6, 5 ], [ -4, 3, -2, 1, 0, -11 ] ];
            int numbers = 0;
            foreach (var i in array)
            {
                foreach (int k in i)
                {
                    if (k > 0) numbers++;
                }
            }
            Console.WriteLine(numbers);*/




            /*int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write(arr[i, k] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1) - 1; k++)
                {
                    if (arr[i, k] > arr[i, k + 1])
                    {
                        int first = arr[i, k];
                        arr[i, k] = arr[i, k + 1];
                        arr[i, k + 1] = first;

                        k = -1;
                    }
                }
            }


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write(arr[i, k] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();*/





            /*var (name, age) = ("Andrej", 30);

            Console.WriteLine("Моё имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}" + " лет", age);

            Console.Write("Напишите Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Напишите Ваш возраст цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя " + name + " и Ваш возраст " + age + " лет.");*/




            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Введите имя Вашего домашнего животного: ");
            Pet.Name = Console.ReadLine();

            Console.Write("Введите тим Вашего питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Введите возраст Вашего питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());

            Pet.NameCount = Pet.Name.Length;

            Console.Write("У Вас есть {0} ", Pet.Type);
            Console.Write(", которую зовут " + Pet.Name);
            Console.WriteLine(", и её возраст " + Pet.Age + ".");
            Console.WriteLine("Длина имени Вашего питомца: {0}" + " символов.", Pet.NameCount);



        }
    }
}
