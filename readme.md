# DataGuard

Data guard \- a system that creates a prediction module based on data that has already been classified and implement it on new data entered by the user.

The prediction is based in the naive bayes probability classifier

—

### interfaces:

| name | signature | What does |
| :---- | :---- | ----- |
| IReader | string\[\]  ReadFile (string file); | קורא קובץ ומחזיר רשימה של שורות |
| IParser | List\<Dictionary\<string, string\>\>DictionaryParser (string\[\] lines); | עובר שורה שורה ברשימה, מפצל לפי פסיקים, ויוצר מילונים שכל שורה  {(value, value, value): lebel} |
| IModule | public module Train(List\<Dictionary\<string, string\>\> rows, string targetColumn); | מקבל רשימה של מילונים {string:string} ואת שם העמודה של lebel, עושה את כל המודל ומחזיר מודול (פסאודו קוד 1\) |
| IPrediction  | string Predict(NaiveBayesModel model, Dictionary\<string, string\> sample); | מחזיר לכל דגימה את תוצאת הסיווג (פסאודו קוד 2\) |
| IWriter | List\<string\>  Write(string\[\] str, string file); | מקבל רשימה ורושם אותה לקובץ |
| IPreparingToFile | List\<string\>  Preparing(List\<Dictionary\<string, string\>\> sample, string predict); | מכין את השורה והתוצאה בפורמט של הקובץ |
| IExport | bool ExportToFile(string file, List\<string\> data); | מכניס את כל השורות המוכנות בפורמט הקובץ לתוך הקובץ |
|  |  |  |

### classes:

| name | type | responsibility |
| :---- | :---- | :---- |
| ModulePipeline | orchestrator | in charge of taking plain text and transform it into module |
| BatchModePipeline | orchestrator | in charge of the flow in batch mode |
| InteractiveInputPipeline | orchestrator | in charge of the flow in interactive mode  |
| CsvReader | Service | incharge of reading the csv |
| DataParsing | Service | takes plain text and transforms it into List of dictionaries  |
| ModuleCreator | entity | in charge of creating the prediction module. |
| Module | entity | the module created by module creator |
| PreparingToCsv | service | in charge of the output text prediction format |
| WriteToCsv | service | in charge of the file prediction output |
| Predict | entity | return the prediction |
| FindPathInFile | service | find path |
|  |  |  |

| ModulePipeline |  |  |
| :---- | :---- | :---- |
| csvReader : IReader | string\[\]  ReadFile (string file); |  |
|  |  |  |

—

## Git Branches:

main  
dev  
dev/feature/ProjectFilesStructure  
dev/feature/csvReader  
dev/feature/Interfaces \- Dovid  
dev/feature/csvReader \-   
dev/feature/DataParsing \-   
dev/feature/ModuleCreator \-   
dev/feature/Module \-   
dev/feature/BatchModePipeline  
dev/feature/InteractiveInputPipeline

dev/feature/PreparingToCsv

