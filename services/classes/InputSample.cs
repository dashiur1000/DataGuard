using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataGuard.services.classes
{
    class InputSample
    {
        public Dictionary<string, string> input(Module model)
        {
            List<string> features = model.Cond.Keys
                .Select(key => key.Item2)
                .Distinct()
                .ToList();

            Dictionary<string, string> sample = new Dictionary<string, string>();
            bool isFirst = true;

            foreach (string feature in features)
            {
                Console.Write($"{feature}: ");
                var value = Console.ReadLine();
                if (isFirst && string.IsNullOrWhiteSpace(value))
                {
                    return null;
                }
                sample[feature] = value ?? string.Empty;
                isFirst = false;
            }
            return sample;
        }
    }
    
}
