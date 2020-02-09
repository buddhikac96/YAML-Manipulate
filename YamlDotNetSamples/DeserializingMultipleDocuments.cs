using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace YamlDotNetSamples
{
    public class DeserializingMultipleDocuments
    {
        public void Run()
        {
            var input = new StringReader(Document);

            var deserializer = new DeserializerBuilder().Build();

            var parser = new Parser(input);

            // comsuming the steam start event manully // check for this
            parser.Consume<StreamStart>();

            while (parser.Accept<DocumentStart>())
            {
                var doc = deserializer.Deserialize<List<string>>(parser);

                Console.WriteLine("##Document");

                foreach (var item in doc)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private const string Document = @"---
- Prisoner
- Goblet
- Phoenix
---
- Memoirs
- Snow 
- Ghost		
...";
    }
}
