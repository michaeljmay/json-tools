using System;
using clipr;

namespace json_file_splitter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var options = CliParser.Parse<Options>(args).GetValueOrThrow();
                JsonFileSplitter.Split(options.InputFile, options.OutputFile, options.Count);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}