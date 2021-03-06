using System;

namespace ConsoleAppModul5
{
    class Program
    {
        static string ShowColor(string username, int age, params string[] favcolor)
        {
            Console.WriteLine(username + "," + age + " лет,\n напишите свой любимый цвет на английском с маленькой буквы");
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

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArray( int[] result)
        {   var num = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        num = result[i];
                        result[i] = result[j];
                        result[j] = num;
                    }
            //Console.WriteLine("Наш отсортированный массивчик: ");
            //foreach (var res in result)
            //{ Console.WriteLine(res); }

            return result;
        }

        static void ShowArray(int[] arr, bool fsort = false)
        { var arrsort = arr;
            if (fsort == true)
            {
                arrsort = SortArray(arr);
            }
                Console.WriteLine("Наш массив: ");
                foreach (var res in arrsort)
                { Console.WriteLine(res); }
        }
        

        public static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя пользователя:");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
           for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите любимое блюдо № {0}", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваше любимое блюдо №3 {0}", User.Dishes[2]);


             (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            var favcolor = new string[3];
            ; for (int i = 0; i < 3; i++)
            {
                favcolor[i] = ShowColor(anketa.name, anketa.age, favcolor);
            }
            
            Console.WriteLine("Ваши цвета:");
            foreach (var color in favcolor)
            { Console.WriteLine(color); }

                 
            var array = new int[10];
            //var arrayS = new int[10];
            //arrayS = SortArray(array);
            array = GetArrayFromConsole(10);

            
            ShowArray(array, true);

            Console.ReadKey();
        }
    }
}
