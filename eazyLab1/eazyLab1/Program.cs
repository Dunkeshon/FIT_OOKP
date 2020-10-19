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

            ArrayList listOfStatements = new ArrayList();


            string input = "" ;

            
            
            while (true)
            {
                
                Console.WriteLine("To enter new statement data press 1");
                Console.WriteLine("To write data from container to text file press 2");
                Console.WriteLine("To write data from file to container(overwrites container if it's not empty) press 3");
                Console.WriteLine("To print all data from statement continer press 4");

                input = Console.ReadLine();
                switch (input)
                {
                    /*а) уведення вихідних дані відомості й кількості її записів у поточному 
                      сеансі роботи з консолі;
                      б)  запис вихідних і розрахункових даних відомості в "контейнер" об'єктів класу 
                      (див. пункт 1);*/
                    case "1":
                        Console.WriteLine("How many statements do you want to enter ?");
                        Console.WriteLine("Number of statements: ");
                        int amount = Int32.Parse(Console.ReadLine());
                        
                        for(int i = 0; i< amount; i++)
                        {
                            listOfStatements.Add(Statement.CreateAndFillFromConsole());
                        }
                        break;
                        /*в) виведення даних відомості з "контейнера" у текстовий файл, ім'я
                            якого вводиться з консолі;*/
                    case "2": 
                        Console.Write("Enter file name that needs to be open or created:");
                        string fileName = Console.ReadLine();
                        if (listOfStatements.Count == 0)
                        {
                            Console.WriteLine("Container is empty");
                        }
                        WorkWithFiles.WriteInfoAtTheEndOfTheFile(fileName, listOfStatements);                        
                        break;

                        /*г) уведення даних відомості з текстового файла в "контейнер" 
                            об'єктів класу (див. пункт 1);*/
                    case "3":
                        Console.Write("Enter file name from which we need to read data: ");
                        string fileReadName = Console.ReadLine();
                        listOfStatements = Statement.GetArrayListOfStatementsFromFile(fileReadName);
                        break;

                        /*д) виведення полів, що розраховуються, кожної із записів відомості,*/
                    case "4":
                        Console.WriteLine("-----------------------");
                        for(int i = 0;i<listOfStatements.Count;i++)
                        {
                            Console.WriteLine("Id: " + i + " | " + listOfStatements[i].ToString());
                        }
                        Console.WriteLine(
                        "Sum of Balance at start of the period: " + Statement.SumOfBalanceAtStart(listOfStatements) + " grn" + " | "
                + "Sum of Received: " + Statement.SumOfReceived(listOfStatements) + " grn" + " | "
                + "Sum of Issued: " + Statement.SumOfIssued(listOfStatements) + " grn" + " | "
                + "Sum of Balance in the end of the period: " + Statement.SumOfBalanceInTheEnd(listOfStatements) + " grn");
                        Console.WriteLine("-----------------------");
                        break;
                    default: Console.WriteLine("Wrong input"); break;

                }

            }


        }
    }
}
