using System;
using System.IO;

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
        }
    }
}
