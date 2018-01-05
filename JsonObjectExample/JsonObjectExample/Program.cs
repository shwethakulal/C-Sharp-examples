using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace JsonObjectExample
{
    class colors
    {
        public string color { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return string.Format("Color: {0} \nCategory: {1}", color, category);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string JSONString = File.ReadAllText(@"data\JSONdata.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            colors c1 = ser.Deserialize<colors>(JSONString);

            Console.WriteLine(c1);

            Console.ReadKey();
            


    }
    }
}
