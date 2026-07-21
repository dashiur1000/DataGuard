using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    internal class PreparingToCsv : IPreparingToFile
    {
        public List<string> Preparing(string[] lines, string predict, NaiveBayesModel model)
        {
            List<string> result = new List<string>();
            List<string> features = new List<string>();
            foreach (var key in model.Keys)
            {
                features.Add(key.Item2);
            }
            string headerLine = string.Join(",", features);
            result.Add(headerLine);
        }
    }
}
