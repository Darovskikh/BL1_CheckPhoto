using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравсвуйте, меня зовут Василиса. Предоставьте список документов");

            var documents = new  string [1];
            const int adultAge = 18;

            var document = Console.ReadLine();
            documents[0] = document;

            Console.WriteLine("How old are you?");
            var age = Int32.Parse(Console.ReadLine());

            if (age >= adultAge)
            {
                Console.WriteLine("Ok. Go to pay");
            }
            else
            {
                Console.WriteLine("Do you have parent permission?");
                bool hasPermision = bool.Parse(Console.ReadLine());

                if (hasPermision == true)
                {
                    Console.WriteLine("Ok. Go to pay");
                }
                else
                {
                    Console.WriteLine("Fail. Go to parents");
                }

            }

            Console.ReadLine();
        }
    }
}
