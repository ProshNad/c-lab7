using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string inp2 = Console.ReadLine();
            string[] w = inp2.Split(' ');
            List<string> li = new List<string>(w);


            string temp2="";
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i][0] > li[j][0])
                    {
                        temp2 = li[i];
                        li[i] = li[j];
                        li[j] = temp2;
                    }
                }
            }
            var r2= String.Join(" ", li.ToArray());
            Console.WriteLine($"Отсортировали по алфавиту: {r2}");

            string str = "";
            for (int i = 0; i < li.Count; i++) {
                str = str + li[i][li[i].Length-1];
            }
            Console.WriteLine($"Получили слово: {str}");






        }
    }
}
