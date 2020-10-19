using System;
using System.Collections;
using System.Collections.Generic;

namespace eazyLab1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");



            string input ="" ;

            
            
            while (true)
            {
                
                Console.WriteLine("To enter new statement data press 1");
                Console.WriteLine("To print info press 2");

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("How many statements do you want to enter ?");
                        int amount = Int32.Parse(Console.ReadLine());
                        
                        List<Book> newBooks = new List<Book>();
                        for(int i = 0; i< amount; i++)
                        {
                            newBooks.Add(EnterBook());
                        }
                        house.PublishBooks(newBooks);
                        break;
                    case "2": Console.WriteLine( house.ToString()); break;
                    default: Console.WriteLine("Wrong input"); break;

                }

            }


        }
    }
}
