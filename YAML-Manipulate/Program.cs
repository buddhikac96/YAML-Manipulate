using System;
using YamlDotNetSamples;

namespace YAML_Manipulate
{
    class Program
    {
        public static void Main(String[] args)
        {
            var loadYamlStream = new LoadingYamlStream();
            loadYamlStream.Run();
        }
    }
}

