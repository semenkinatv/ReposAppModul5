using System;

namespace ConsoleAppModul5
{
    class Program
    {
        static string ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }

            return color;
    }

        public static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя пользователя:");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            ; for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите любимое блюдо № {0}", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваше любимое блюдо №3 {0}", User.Dishes[2]);

            
            //var (name, age) = ("Евгения", 27);

            //Console.WriteLine("Мое имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);

            //Console.Write("Введите имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами:");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            var favcolor = new string[3];
            ; for (int i = 0; i < 3; i++)
            {
                favcolor[i] = ShowColor();
            }
            
            Console.WriteLine("Ваши цвета:");
            foreach (var color in favcolor)
            { Console.WriteLine(color); }

            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }
                var num = 0;
                for (int i = 0; i < result.Length; i++)
                    for (int j = i + 1; j < result.Length; j++)
                         if (result[i] > result[j])
                        {   num = result[i];
                            result[i] = result[j];
                            result[j] = num;
                        }
                Console.WriteLine("Наш массивчик: ");
                foreach (var res in result)
                { Console.WriteLine(res); }

                        return result;
            }
            
            var array = new int[5];
            array = GetArrayFromConsole();

            Console.ReadKey();
        }
    }
}
