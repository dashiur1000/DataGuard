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
            List<Dictionary<string, string>> pars = parser.DictionaryParser(lines);
            string firstLine = FormatConverter.Preparing(model);
            string[] headers = firstLine.Split(',');

            string originalHeader = lines[0];

            foreach (Dictionary<string, string> par in pars)
            {
                string Predict = prediction.Predict(model, par);
                lineCount++;

                List<string> orderedValues = new List<string>();
                foreach (var header in headers)
                {
                    if (par.ContainsKey(header))
                    {
                        orderedValues.Add(par[header]);
                    }
                }

                string featuresJoined = string.Join(",", orderedValues);
                Console.WriteLine($"row {lineCount}: {featuresJoined} -> {Predict}");
                PerfectLines.Add($"{featuresJoined},{Predict}");
            }

            PerfectLines.Insert(0, originalHeader);
            writeToCsv.Write(PerfectLines.ToArray(), OutputPath);
            return true;
        }
    }
}