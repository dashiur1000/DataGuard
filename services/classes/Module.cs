using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataGuard.services.classes
{
    public class Module
    {
        public Dictionary<(string, string, string), double> CalculateMoudle(List<Dictionary<string, string>> inputData, string targetColumn)
        {
            int numberOfRows = inputData.Count;

            List<string> labels =
                inputData.Select(row => row[targetColumn])
                .Distinct()
                .ToList();

            Dictionary<string, int> priors = GetPriors(labels, inputData, targetColumn);

            Dictionary<(string, string, string), double> cond = new();
            Dictionary<(string, string, string), double> unseen = new();

            foreach (string label in labels)
            {
                var Rows = inputData.Where(dict => dict[targetColumn] == label);


                List<string> features = Rows.ToList()[0].Keys.ToList(); // gets the columns names
                foreach (var feature in features)
                {
                    if (feature == targetColumn) { continue; } // skips the target column
                    int distinct = inputData.Select(row => row[feature]).Distinct().Count();

                    List<string> values = inputData.Select(row => row[feature]).Distinct().ToList();
                    
                    foreach (string value in values)
                    {
                        Console.WriteLine(value);
                        double match = Rows.Count(row => row[feature] == value);
                        
                        cond[(label, feature, value)] = (double)(match + 1) / (Rows.Count() + distinct);
                    }
                }
            }

            foreach (var c in cond)
            {
                Console.WriteLine($"k: {c.Key} : v: {c.Value}");
            }

            return new Dictionary<(string, string, string), double>();
        }


        /// <summary>
        /// gets the count of each label in the target column.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="inputData"></param>
        /// <param name="targetColumn"></param>
        /// <returns></returns>
        Dictionary<string, int> GetPriors(List<string> labels, List<Dictionary<string, string>> inputData, string targetColumn)
        {
            Dictionary<string, int> priors = new();

            foreach (string label in labels)
            {
                priors[label] = inputData.Count(row => row[targetColumn] == label);
            }

            return priors;
        }

        void GetCond()
        {

        }
    }
}
