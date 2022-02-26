using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SayHelloDiscordBot
{
      class Test
    {
        public static void Main(string[] args)
        {
            var set = ConfigurationManager.AppSettings["setting1"];
            var set2 = ConfigurationManager.AppSettings["setting2"];
            Console.WriteLine(set, set2);
        }
    }
}
