using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{

    public class Program
    {
        public static void GenerateDialogue(string person1, string person2)
        {
            RonVSKanyeAPI ronVSKanyeAPI = new RonVSKanyeAPI();

            for(int i = 0; i < 5; i++)
            {

                Console.WriteLine($"{person1}:");

                Console.WriteLine(ronVSKanyeAPI.GetKanyeQuote());

                Console.WriteLine();

                Console.WriteLine($"{person2}:");

                Console.WriteLine(ronVSKanyeAPI.GetRonQuote());

                Console.WriteLine();

                Task.Delay(250).Wait();
            }

        }


        static void Main(string[] args)
        {
            GenerateDialogue("Kanye West", "Ron Swanson");
        }
    }
}
