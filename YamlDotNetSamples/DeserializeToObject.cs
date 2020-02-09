using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace YamlDotNetSamples
{
    public class DeserializeToObject
    {

        public void Run()
        {
            string input = "";

            using (var sr = new StreamReader(@"E:\Projects\Practice\DOT NET\YAML-Manipulate\YamlDotNetSamples\student.yaml")) {
                input = sr.ReadToEnd();
                Console.WriteLine(input);
            }

            var deserializer = new DeserializerBuilder().Build();

            var student = deserializer.Deserialize<Student>(input);

            //Console.WriteLine(student.name);

            /*foreach (var subject in student.subjects)
            {
                Console.WriteLine(subject);
            }*/

            Console.WriteLine(student.name);
        }
    }

    public class Student
    {
        public string name { get; set; }
        public string email{ get; set; }
        public string mobile { get; set; }
        //public List<string> subjects { get; set; }
    }

    public class Subject
    {
        public string topic { get; set; }
    }

    
}
