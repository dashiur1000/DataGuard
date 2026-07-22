using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    internal class PreparingToCsv : IPreparingToFile
    {
        public List<string> Preparing(string[] lines, string predict, ModuleCreator model)
        {
            List<string> result = new List<string>();
            IEnumerable<string> features = model.cond.Keys
                .Select(key => key.Item2)
                .Distinct();
            string headerLine = string.Join(",", features);
            result.Add(headerLine);
            return result;
        }
    }
}
