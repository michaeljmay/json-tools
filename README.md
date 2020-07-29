# json-tools

## json-file-splitter
- splits a large json file into smaller ones based on document count
- Usage:
```bash
dotnet json-file-splitter.dll -i large_input_file.json -o smaller-file -c 1000
```
- If `large_input_file.json` had 3000 documents, 3 output files will be generated: `smaller-file-001.json`, `smaller-file-002.json`, `smaller-file-003.json`