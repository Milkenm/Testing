using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JsonTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\json.json";

            // read file into a string and deserialize JSON to a type
            Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(file));
            Console.WriteLine(config.value1);

            // deserialize JSON directly from a file
            using (StreamReader file2 = File.OpenText(file))
            {
                Config config2 = (Config)new JsonSerializer().Deserialize(file2, typeof(Config));
                Console.WriteLine(config2.value2);
            }
        }
        
        private class Config
        {
            public string value1 = "default";
            public int value2 = -1;
        }
    }
}
