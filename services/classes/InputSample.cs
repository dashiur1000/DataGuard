using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    class InputSample
    {
        public Dictionary<string, string> input(Dictionary<(string, string, string), double> model)
        {
            List<string> features = new List<string>();
            foreach (var key in model.Keys)
            {
                features.Add(key.Item2);
            }
            List<string> inputs = new List<string>();
            Dictionary<string, string> sample = new Dictionary<string, string>();
            foreach (string feature in features)
            {
                Console.Write($"{feature}: ");
                var value = Console.ReadLine();
                if(value == string.Empty)
                {
                    Environment.Exit(0);
                }
                sample.Add(feature, value);
            }
            return sample;
        }
    }
    
}
