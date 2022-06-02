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
            int allWaiting;
            int waitHours;
            int waitMinutes;
            int minutesInHours = 60;
            string input;

            Console.WriteLine("Вы заходите в поликлинику и видите огромную очередь из старушек.");
            Console.WriteLine("введите количество старушек:");
            input = Console.ReadLine();
            allPeople = Convert.ToInt32(input);
            waitHours = (allPeople * onePeopleWait) / minutesInHours;
            waitMinutes = (allPeople * onePeopleWait) % minutesInHours;
            Console.WriteLine($"Надо ждать {waitHours} часов и {waitMinutes} минут.");
        }
    }
}
