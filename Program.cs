using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаба 7:");
            string inp= Console.ReadLine();
            var mas = inp.ToCharArray();

            char temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
           
            var r = String.Join("", mas);
            Console.WriteLine($"По возрастанию:{r}");

            Console.WriteLine("Лаба 6:");
            Console.WriteLine("Введите произвольное количество слов:");






        }
    }
}
