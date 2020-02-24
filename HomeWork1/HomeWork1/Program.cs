using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello!";
            HelloUser();
            Console.ReadLine();
        }
        static void HelloUser()
        {
            Console.Write("Введите свое имя: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Здравствуй, {0}!", userName);
        }
    }
}
