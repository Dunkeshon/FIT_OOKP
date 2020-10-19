using System;
using System.Collections;
using System.Text;
using System.IO;

namespace eazyLab1
{
    class WorkWithFiles
    {
        public static string ReadEverythingFromFile(string fileName)
        {
            try
            {
                // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(fileName))
                {
                    // Read the stream as a string, and return string 
                   return sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
           
            return "";
        }

        // brief writes to the end of file all the info from given statementList

        public static void WriteInfoAtTheEndOfTheFile(string fileName,ArrayList statementList )
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, true, System.Text.Encoding.Default))
                {
                    foreach(Statement i in statementList)
                    {
                        sw.WriteLine(i.ToStringUsingBackslash());
                    }
                    Console.WriteLine("Write to file succeed");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // brief writes to file all the info from given statementList
        // truncates the file 
        public static void WriteInfoToFile(string fileName, ArrayList statementList)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
                {
                    foreach (Statement i in statementList)
                    {
                        sw.WriteLine(i.ToStringUsingBackslash());
                    }
                    Console.WriteLine("Write to file succeed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
