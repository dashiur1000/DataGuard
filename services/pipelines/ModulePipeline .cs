using DataGuard.services.classes;
using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.pipelines
{
    class ModulePipeline
    {
        static public Module FirstPipeline(string[] args)
        {
            FindPathInFile pathFinder = new FindPathInFile();
            IReader reader = new CsvReader();
            IParser parser = new DataParsing();
            Module model = new Module();

            string TrainingPath = pathFinder.FoundPath(args[0]);
            string[] lines = reader.ReadFile(TrainingPath);
            string[] parts = lines[0].Split(",");
            string targetColumn = parts[^1];
            List < Dictionary<string, string>> pars = parser.DictionaryParser(lines);
            model.Train(pars, targetColumn);
            return model;
        }
    }
}
