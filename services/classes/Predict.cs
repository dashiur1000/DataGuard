using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    class Predict : IPrediction
    {
        static string Predict(NaiveBayesModel model, Dictionary<string, string> sample)
        {
            string bestLabel = null;
            double bestScore = double.NegativeInfinity;
            foreach (string label in model.Labels)
            {
                double score = model.prios[label];
                foreach (KeyValuePair<string, string> item in sample)
                {
                    string feature = item.Key;
                    string value = item.Value;
                    if (model.cond.ContainsKey((label, feature, value))
                    {
                        score = score * model.cond[(label, feature, value)];
                    }
                    else
                        score = score * model.unseen[(label, feature)];
                if(score > bestScore)
                    {
                        bestScore = score;
                        bestLabel = label;
                    }
                }
            }
            return bestLabel;
        }
    }
}
