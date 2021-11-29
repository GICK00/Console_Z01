using System;

namespace Console_Z01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Проверка суммы цифр числа на не четность.");
            bool repit = true;
            try
            {
                while (repit == true)
                {
                    Console.Write("| Введите двузначное число: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n.ToString().Length == 2)
                    {
                        int sum = 0;
                        while (n > 0)
                        {
                            sum = sum + n % 10;
                            n = n / 10;
                        }

                        if (sum % 2 != 0)
                        {
                            Console.WriteLine("| Сумма цифр {0} не четное", sum);
                        }
                        else
                        {
                            Console.WriteLine("| Сумма цифр {0} четное", sum);
                        }

                        Console.WriteLine("|---------------------------");
                        Console.WriteLine("| Попробовать снова? Да / Нет");
                        Console.Write("| : ");
                        string repitTxT = Convert.ToString(Console.ReadLine());

                        if (repitTxT == "Да")
                        {
                            repit = true;
                            Console.WriteLine("|---------------------------");
                        }
                        else
                            repit = false;
                    }
                    else
                    {
                        Console.WriteLine("| Введите двузначное число!");
                        Console.WriteLine("|---------------------------");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("|---------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                Console.WriteLine("| Попробовать снова? Да / Нет");
                Console.Write("| : ");
                string repitTxT = Convert.ToString(Console.ReadLine());
                try
                {
                    if (repitTxT == "Да")
                    {
                        repit = true;
                        Console.WriteLine("|---------------------------");
                    }
                    else
                    {
                        if (repitTxT == "Нет")
                        {
                            repit = false;
                        }
                        else
                        {
                            Console.WriteLine("|---------------------------");
                            Console.WriteLine("| Некорректный ввод данных!");
                            repit = false;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("|---------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    repit = false;
                }
            }
        }
    }
}
