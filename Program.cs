using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPeople;
            int onePeopleWait = 10;
            int allwaiting;
            int hours;
            int minutes;
            string input;

            Console.WriteLine("Вы заходите в поликлинику и видите огромную очередь из старушек.");
            Console.WriteLine("введите количество старушек:");
            input = Console.ReadLine();
            allPeople = Convert.ToInt32(input);
            hours = (allPeople * onePeopleWait) / 60;
            minutes = (allPeople * onePeopleWait) % 60;
            Console.WriteLine($"Надо ждать {hours} часов и {minutes} минут.");
        }
    }
}
