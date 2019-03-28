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

            var documents = new  string [2];
            const int adultAge = 18;

            var document = Console.ReadLine();
            documents[0] = document;

            Console.WriteLine("How old are you?");
            var age = Int32.Parse(Console.ReadLine());

            if (age >= adultAge)
            {
                CheckPhoto(documents);
            }
            else
            {
                Console.WriteLine("Do you have parent permission?");
                bool hasPermision = bool.Parse(Console.ReadLine());

                if (hasPermision == true)
                {
                    CheckPhoto(documents);
                }
                else
                {
                    Console.WriteLine("Fail. Go to parents");
                }

            }            
            Console.ReadLine();
        }
        static void CheckPhoto(string [] docs)
        {
            foreach (string doc in docs)
            {
                if ((doc != "фото") && (doc != "Фото"))
                {
                    Console.WriteLine("Пожалуйста, сделайте фото");
                    break;
                }
                else
                {
                    Console.WriteLine("Ok. Go to pay.");
                }
                        
            }
        }
    }
}
