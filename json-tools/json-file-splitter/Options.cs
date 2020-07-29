using clipr;

namespace json_file_splitter
{
    [ApplicationInfo(Description = "json-file-splitter options")]
    public class Options
    {
        [NamedArgument(
            shortName: 'i', 
            longName: "input-file", 
            Action = ParseAction.Store, 
            Description = "Input filename")]
        public string InputFile { get; set; }

        [NamedArgument(
            shortName: 'o', 
            longName: "output-file", 
            Action = ParseAction.Store, 
            Description = "Output filename")]
        public string OutputFile { get; set; }

        [NamedArgument(
            shortName: 'c', 
            longName: "document-count", 
            Action = ParseAction.Store, 
            Description = "Document count per file")]
        public int Count { get; set; }
    }
}