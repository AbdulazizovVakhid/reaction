using System;
using System.Threading;

namespace реакция
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест на реакцию");
            Console.WriteLine("Вам надо будет ввести букву которую вы увидете на экране");
            Console.WriteLine("Жми Enter ");
            Console.ReadLine();
            Random1;
            Console.WriteLine();
            Time1;
            Console.WriteLine();
        }
    }
    class Random1
    {
        public void ran ()
        {
            Random randomizZnak = new Random();
            char[] Znak = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Thread.Sleep(randomizZnak.Next(1000, 5000));
            char znakRandom = Znak[randomizZnak.Next(0, Znak.Length)];
            Console.WriteLine(znakRandom);
            while ((char)Console.ReadKey().KeyChar != znakRandom)
            {
            }
        }
    }
    class Time1
    {
        public void Totime ()
        {
            DateTime time = DateTime.Now;
            TimeSpan timeCansel = DateTime.Now - time;
            Console.WriteLine($"Время реакции {timeCansel.TotalSeconds} сек");
        }
    }
}
