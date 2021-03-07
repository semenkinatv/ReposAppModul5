using System;

namespace ConsoleAppModul5
{
    class Program
    {
        // -------------5.6 Итоговый проект-------------------------------------------
        static (string Name, string LastName, int Age, bool HasPet, int CountPet, string[] PetName, int CountFavColors, string[] FavColors) EnterUser()
        {
            (string Name, string LastName, int Age, bool HasPet, int CountPet, string[] PetName, int CountFavColors, string[] FavColors) User;
            Console.WriteLine("Введите имя:");
            User.Name = Console.ReadLine();
           
            Console.WriteLine("Введите фамилию:");
            User.LastName = Console.ReadLine();
           
            string num;
            int intnum;
            bool isnum;
            do
            {   Console.WriteLine("Введите возраст цифрами:");
                num = Console.ReadLine();
                isnum = CheckNum(num, out intnum);
            } while (isnum == false);

            User.Age = intnum;

            Console.WriteLine("Есть ли дома питомец да/нет:");
            var pet = Console.ReadLine();
           
            if (pet == "да")
            { User.HasPet = true;
                do
                {   Console.WriteLine("Введите количество питомцев:");
                    num = Console.ReadLine();
                    isnum = CheckNum(num, out intnum);
                } while (isnum == false);

                User.CountPet = intnum;

                User.PetName = GetPetName(User.CountPet);
            }
            else
            { User.HasPet = false;
              User.CountPet = 0;
              User.PetName = new string[0];
            }


            do
            {
                Console.WriteLine("Введите кол-во любимых цветов:");
                num = Console.ReadLine();
                isnum = CheckNum(num, out intnum);
            } while (isnum == false);

            
            User.CountFavColors = intnum;

            User.FavColors = GetFavColors(User.CountFavColors);

            return User;
        }

        //метод, принимающий на вход кол-во питомцев и возвращающий массив их кличек
        static string[] GetPetName(int kol)
        { var PetName = new string[kol];
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine("Введите кличку питомца № {0}", i +1);
                PetName[i] = Console.ReadLine();
            }
            return PetName;
        }

        // метод, который возвращает массив любимых цветов по их количеству
        static string[] GetFavColors(int kol)
        {
            var FavColors = new string[kol];
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine("Введите любимый цвет № {0} на английском с маленькой буквы:", i + 1);
                FavColors[i] = Console.ReadLine();
            }
            return FavColors;
        }

        //Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
        static void WriteData()
        {
            (string Name, string LastName, int Age, bool HasPet, int CountPet, string[] PetName, int CountFavColors, string[] FavColors) Data;
            Data = EnterUser();

            Console.WriteLine("\nАнкетирование закончено. Получены следующие данные по пользователю:");
            Console.WriteLine("Имя: " + Data.Name);
            Console.WriteLine("Фамилия: " + Data.LastName);
            Console.WriteLine("Возраст: " + Data.Age);
            Console.WriteLine("Имеет питомца: " + Data.HasPet);
            Console.WriteLine("Количество питомцев: " + Data.CountPet);

            Console.WriteLine("Перечень их кличек:");
            foreach (var item in Data.PetName)
            { Console.WriteLine(item); }

            Console.WriteLine("Количество любимых цветов: " + Data.CountFavColors);
            
            Console.WriteLine("Перечень любимых цветов:");
            foreach (var item in Data.FavColors)
            { Console.WriteLine(item); }
        }

        static bool CheckNum(string number, out int corrnumber)
        { if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                { corrnumber = intnum;
                    return true;
                }
            }
            {
                corrnumber = 0;
                return false;
            }
        }

        public static void Main(string[] args)
        {   // -------Итоговый проект------------------------------------------------------
            
            WriteData();


            //------- Материалы модуля 5---------------------------------------------------
            Console.WriteLine("\n\nМатериалы модуля 5.");

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

            // 5.5 ------------Рекурсия
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.WriteLine(PowerUp(2, 3));

            Console.ReadKey();
        }

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

        static int[] GetArrayFromConsole(ref int num)
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

        static int[] SortArray(int[] result)
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
        {
            var arrsort = arr;
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

        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
             }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        static int PowerUp(int N, byte pow)
         { 
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                    
                }
            }

        }
       

    }
}
