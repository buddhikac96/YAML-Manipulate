using System;
using System.IO;
using YamlDotNet.Serialization;

namespace YamlDotNetPractice
{
    public class GetData
    {
        public void Run()
        {
            string input = null;

            using (var reader = new StreamReader(@"E:\Projects\Practice\DOT NET\YAML-Manipulate\YamlDotNetPractice\template.yaml"))
            {
                input = reader.ReadToEnd();
                Console.WriteLine(input);
            }

            var deserializer = new DeserializerBuilder().Build();

            var config = deserializer.Deserialize<YAMLConfig>(input);

            Console.WriteLine(config.service.id);
        }
    }

    public class YAMLConfig
    {
        public Service service { get; set; }
    }

    public class Service
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string executable { get; set; }
        public string priority { get; set; }
        public string stoptimeout { get; set; }
        public Boolean stopparentprocessfirst { get; set; }
        public string startmode { get; set; }
        public string waithint { get; set; }
        public string sleeptime { get; set; }
        public Log log { get; set; }
    }

    public class Log
    {
        public string _mode { get; set; }
    }
}
