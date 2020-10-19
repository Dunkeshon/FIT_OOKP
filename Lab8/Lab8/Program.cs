using System;
using System.Collections;
using System.Collections.Generic;


    class Program
    {
        public static Book EnterBook()
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author's name: ");
            string author = Console.ReadLine();
            return new Book(title, author);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");



            string input = "";

            PublishingHouse house = new PublishingHouse("Sun House", new List<Book>(), 2001, 0);
            while (true)
            {

                Console.WriteLine("To publish book press 1");
                Console.WriteLine("To print info press 2");

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("How many books you want to publish?");
                        int amount = Int32.Parse(Console.ReadLine());
                        List<Book> newBooks = new List<Book>();
                        for (int i = 0; i < amount; i++)
                        {
                            newBooks.Add(EnterBook());
                        }
                        house.PublishBooks(newBooks);
                        break;
                    case "2": Console.WriteLine(house.ToString()); break;
                    default: Console.WriteLine("Wrong input"); break;

                }

            }


        }
    }

