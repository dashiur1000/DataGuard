using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IPrediction
{
    string Predict(NaiveBayesModel model, Dictionary<string, string> sample);
}