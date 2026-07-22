using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    internal class PreparingToCsv : IPreparingToFile
    {
        public string Preparing(Module model)
        {
            //List<string> result = new List<string>();
            IEnumerable<string> features = model.cond.Keys
                .Select(key => key.Item2)
                .Distinct();
            string firstLine = string.Join(",", features);
            //result.Add(headerLine);
            return firstLine;
        }
    }
}
