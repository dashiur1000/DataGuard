using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataGuard.services.classes
{
    public class Module
    {
        public List<string> Labels { get; set; } = new();
        public Dictionary<string, int> Priors { get; set; } = new();
        public Dictionary<(string, string, string), double> Cond { get; set; } = new();
        public Dictionary<(string, string), double> Unseen { get; set; } = new();





        public void Train(List<Dictionary<string, string>> inputData, string targetColumn)
        {
            int numberOfRows = inputData.Count;

            Labels =
                inputData.Select(row => row[targetColumn])
                .Distinct()
                .ToList();

            Priors = GetPriors(Labels, inputData, targetColumn);

            foreach (string label in Labels)
            {
                var Rows = inputData.Where(dict => dict[targetColumn] == label);


                List<string> features = inputData[0].Keys.ToList(); // gets the columns names
                foreach (var feature in features)
                {
                    if (feature == targetColumn) { continue; } // skips the target column
                    int distinct = inputData.Select(row => row[feature]).Distinct().Count();

                    List<string> values = inputData.Select(row => row[feature]).Distinct().ToList();
                    
                    foreach (string value in values)
                    {
                        double match = Rows.Count(row => row[feature] == value);
                        
                        Cond[(label, feature, value)] = (double)(match + 1) / (Rows.Count() + distinct);
                    }
                    Unseen[(label, feature)] = 1.0 / (Rows.Count() + distinct);
                }
            }

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
    }
}
