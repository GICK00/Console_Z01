using System;

namespace Console_Z01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repit = true;
            while(repit == true)
            {
                repit = false;
                try
                {
                    Console.WriteLine("| Введите объем куба.");
                    Console.Write("| V = ");
                    double V = Convert.ToDouble(Console.ReadLine());
                    double result = Math.Pow(V, 1 / 3.0);
                    Console.WriteLine("| Ребро куба = " + result);

                    Console.WriteLine("|---------------------------");
                    Console.WriteLine("| Попробовать снова? Да / Нет");
                    Console.Write("| : ");
                    string repitTxT = Convert.ToString(Console.ReadLine());

                    if (repitTxT == "Да")
                    {
                        repit = true;
                        Console.WriteLine("|---------------------------");
                    }
                    else if (repitTxT == "Нет")
                        repit = false;
                    else
                    {
                        Console.WriteLine("|---------------------------");
                        Console.WriteLine("| Некорректный ввод данных!");
                        repit = false;
                    }
                } 
                catch (Exception)
                {
                    Console.WriteLine("|---------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    Console.WriteLine("| Попробовать снова? Да / Нет");
                    Console.Write("| : ");
                    string repitTxT = Convert.ToString(Console.ReadLine());
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
            }
        }
    }
}