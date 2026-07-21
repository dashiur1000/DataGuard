using System;
using System.Collections.Generic;
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

            Dictionary<string, int> priors = new();

            foreach (string label in labels)
            {
                priors[label] = inputData.Count(row => row[targetColumn] == label); 
            }



            return new Dictionary<(string, string, string), double>();
        }   
    }
}
