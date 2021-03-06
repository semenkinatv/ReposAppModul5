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

        static int[] GetArrayFromConsole(ref int num )
        {
            num = 6;
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
             return result;
        }
        static int[] SortArrayDesc(int[] result)
        {
            var num = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] < result[j])
                    {
                        num = result[i];
                        result[i] = result[j];
                        result[j] = num;
                    }
            return result;
        }


        static int[] SortArrayAsc(int[] result)
        {
            var num = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        num = result[i];
                        result[i] = result[j];
                        result[j] = num;
                    }
            return result;
        }
        static void SortArray1(int[] result, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(result);
            sortedasc = SortArrayAsc(result);
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

        static void GetName(ref string name)
        {
            Console.WriteLine(name + ", Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Ввели имя " + name);
        }

        public static void Main(string[] args)
        {
            var name1 = "Таня";
            GetName(ref name1);
            Console.WriteLine("Переменная стала = " + name1);

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
            var num = 10;
            array = GetArrayFromConsole(ref num);
              
            ShowArray(array, true);
            Console.WriteLine("Переменная num была 10, стала " + num);

            var sorteddesc = new int[10];
            var sortedasc = new int[10];
            SortArray1( array, out sorteddesc, out  sortedasc);

            Console.ReadKey();
        }
    }
}
