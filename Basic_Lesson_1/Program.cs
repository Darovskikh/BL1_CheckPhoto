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
            for (int i=0; i<documents.Length; i++)
            {
                documents[i] = Console.ReadLine();
            }                        
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
            int p = 0;
            foreach (string doc in docs)
            {
                if (doc == "photo")
                {
                    Console.WriteLine("Ok. Go to pay.");                    
                    break;
                }
                else
                {
                    p++;
                }
                if (p==docs.Length)
                {
                    Console.WriteLine("Take a photo");
                }
            }
        }
    }
}
