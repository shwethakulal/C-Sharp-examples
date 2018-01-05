using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                using (StreamReader sr = new StreamReader(@"data\JsonData.json"))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Console.WriteLine(line);

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
