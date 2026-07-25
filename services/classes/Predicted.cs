using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    class Predicted : IPrediction
    {
        public string Predict(Module model, Dictionary<string, string> sample)
        {
            string bestLabel = null;
            double bestScore = double.NegativeInfinity;
            foreach (string label in model.Labels)
            {
                double score = model.Priors[label];
                foreach (KeyValuePair<string, string> item in sample)
                {
                    string feature = item.Key;
                    string value = item.Value;
                    if (model.Labels.Contains(feature) || feature == "Buys_Computer") // או להתאים לשם העמודה
                    {
                        continue;
                    }
                    if (model.Cond.ContainsKey((label, feature, value)))
                    {
                        score = score * model.Cond[(label, feature, value)];
                    }
                    var unseenKey = (label, feature);
                    if (model.Unseen.ContainsKey(unseenKey))
                    {
                        score = score * model.Unseen[unseenKey];
                    }
                    else
                    {
                        score = score * 0.0001;
                    }
                }
                if (score > bestScore)
                {
                    bestScore = score;
                    bestLabel = label;
                }
            }
            return bestLabel;
        }
    }
}
