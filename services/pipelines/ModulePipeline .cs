using DataGuard.services.classes;
using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.pipelines
{
    class ModulePipeline
    {
        static public ModuleCreator FirstPipeline(string[] args)
        {
            FindPathInFile pathFinder = new FindPathInFile();
            IReader reader = new CsvReader();
            IParser parser = new DataParsing();
            Module module = new Module();

            string TrainingPath = pathFinder.FoundPath(args[0]);
            string[] lines = reader.ReadFile(TrainingPath);
            List<Dictionary<string, string>> pars = parser.DictionaryParser(lines);
            module.Train(pars);
        }
    }
}
