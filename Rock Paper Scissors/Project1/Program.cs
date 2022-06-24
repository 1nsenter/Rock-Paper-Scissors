using System;

namespace Progect1
{
    class Program
    {
        static void Main()
        {
            int i = 1, p1, p2;
            string? PlayerName1, PlayerName2;

            Random random = new Random();

            Console.WriteLine("Добро пожаловать в игру \"Камень, Ножницы, Бумага\"");
            Console.Write("Введите имя Первого Игрока: ");

            PlayerName1 = Console.ReadLine();

            Console.Write("\nВведите имя Второго Игрока: ");

            PlayerName2 = Console.ReadLine();

            while (i >= 1)
            {
                Console.WriteLine("\nДля начала игры введите слово \"start\" или для выхода \"quit\"");
                string? result = Console.ReadLine();
                if (result == "start")
                {
                    p1 = random.Next(1, 3);
                    p2 = random.Next(1, 3);
                    // 1 = ножницы
                    // 2 = камень
                    // 3 = бумага
                    if (p1 == 1 && p2 == 2)
                    {
                        Console.WriteLine($"{PlayerName1} = ножницы | камень = {PlayerName2}");
                        Console.WriteLine($"Результат: Победил {PlayerName2}");
                    }
                    else if (p1 == 1 && p2 == 3)
                    {
                        Console.WriteLine($"{PlayerName1} = ножницы | бумага = {PlayerName2}");
                        Console.WriteLine($"Результат: Победил {PlayerName1}");
                    }
                    else if (p1 == 1 && p2 == 1)
                    {
                        Console.WriteLine($"{PlayerName1} = ножницы | ножницы = {PlayerName2}");
                        Console.WriteLine($"Результат: Ничья");
                    }
                    else if (p1 == 2 && p2 == 2)
                    {
                        Console.WriteLine($"{PlayerName1} = камень | камень = {PlayerName2}");
                        Console.WriteLine($"Результат: Ничья");
                    }
                    else if (p1 == 2 && p2 == 1)
                    {
                        Console.WriteLine($"{PlayerName1} = камень | ножницы = {PlayerName2}");
                        Console.WriteLine($"Результат: Победил {PlayerName1}");
                    }
                    else if (p1 == 2 && p2 == 3)
                    {
                        Console.WriteLine($"{PlayerName1} = камень | бумага = {PlayerName2}");
                        Console.WriteLine($"Результат: Победил {PlayerName2}");
                    }
                    else if (p1 == 3 && p2 == 3)
                    {
                        Console.WriteLine($"{PlayerName1} = бумага | бумага = {PlayerName2}");
                        Console.WriteLine($"Результат: Ничья");
                    }
                    else if (p1 == 3 && p2 == 1)
                    {
                        Console.WriteLine($"{PlayerName1} = бумага | ножницы = {PlayerName2}");
                        Console.WriteLine($"Результат: Победил {PlayerName2}");
                    }
                    else if (p1 == 3 && p2 == 2)
                    {
                        Console.WriteLine($"{PlayerName1} = бумага | камень = {PlayerName2}");
                        Console.WriteLine($"Результат: Победил {PlayerName1}");
                    }
                }
                else if (result == "quit")
                {
                    Console.WriteLine("Спасибо за игру!");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка, введите корректное значение!");
                }
            }   
        }
    }   

}

