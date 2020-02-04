using System;
using YamlDotNetSamples;

namespace YAML_Manipulate
{
    class Program
    {
        public static void Main(String[] args)
        {
            //Load yaml string as a stream
            /*var loadYamlStream = new LoadingYamlStream();
            loadYamlStream.Run();*/

            /*var loadingYamlFileAsStream = new LoadingYamlFileAsStream();
            loadingYamlFileAsStream.Run();*/

            /*var convertYamlToJson = new ConvertYamlToJson();
            convertYamlToJson.Run();*/

            var deserializeToObject = new DeserializeToObject();
            deserializeToObject.Run();

            Console.ReadKey();
        }
    }
}

