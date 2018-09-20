using System.IO;
using System;

namespace Document
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Document");
            Console.WriteLine("Please enter the name of the document:  ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Type some content into this document please: ");
            string s2 = Console.ReadLine();
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("Document.txt");

                //Write a line of text
                sw.WriteLine(s1 + s2);

               

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {

                Console.WriteLine(s1 +  " ", "was successfully saved.The document contains");
            }
        }
    }
}
