using System;

namespace ConsoleAppModul5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя пользователя:");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
;            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите любимое блюдо № {0}", i + 1);
                User.Dishes[i] = Console.ReadLine();
             }

            Console.WriteLine("Ваше любимое блюдо №3 {0}", User.Dishes[2]);

            Console.ReadKey();
        }
    }
}
