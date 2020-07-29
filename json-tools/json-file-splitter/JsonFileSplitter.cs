using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace json_file_splitter
{
    public static class JsonFileSplitter
    {
        public static void Split(string inputFile, string outputFile, int maxCount)
        {
            var serializer = new JsonSerializer();
            var items = new List<dynamic>();
            var index = 0;
            using var ifs = File.Open(inputFile, FileMode.Open);
            using var sr = new StreamReader(ifs);
            using JsonReader reader = new JsonTextReader(sr);
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.StartObject)
                {
                    dynamic item = serializer.Deserialize(reader);
                    items.Add(item);
                }

                if (items.Count != maxCount) continue;
                WriteFile(items, outputFile, index);
                items.Clear();
                index++;
            }

            if (items.Count > 0)
            {
                WriteFile(items, outputFile, index);
            }
        }

        private static void WriteFile(List<dynamic> items, string outputFile, int index)
        {
            File.WriteAllText(@$"{outputFile}-{index:D3}.json", JsonConvert.SerializeObject(items));
        }
    }
}