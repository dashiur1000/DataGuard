using DataGuard.services.classes;
using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.pipelines
{
    internal class BatchModePipeline
    {
        public bool FilePipeline(string[] args, Module model)
        {
            FindPathInFile pathFinder = new FindPathInFile();
            IReader reader = new CsvReader();
            IParser parser = new DataParsing();
            IPrediction prediction = new Predicted();
            IPreparingToFile FormatConverter = new PreparingToCsv();
            WriteToCsv writeToCsv = new WriteToCsv();

            int lineCount = 0;
            string[] path = ["output"];
            string OutputPath = pathFinder.FoundPath("predictions.csv", path);
            List<string> PerfectLines = new List<string>();

            string SamplePath = pathFinder.FoundPath(args[1]);
            string[] lines = reader.ReadFile(SamplePath);
            List<Dictionary<string, string>>  pars = parser.DictionaryParser(lines);
            foreach (Dictionary<string,string> par in pars)
            {
                string Predict = prediction.Predict(model, par);
                lineCount ++;
                Console.WriteLine($"row {lineCount}: {lines[lineCount]} -> {Predict}");
                PerfectLines.Add(lines[lineCount]);
                PerfectLines.Add(",");
                PerfectLines.Add(Predict);
            }
            string firstLine = FormatConverter.Preparing(model);
            PerfectLines.Insert(0, firstLine);
            writeToCsv.Write(PerfectLines.ToArray(), OutputPath);
            return true;
        }
    }
}
