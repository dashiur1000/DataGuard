using DataGuard.services.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IPrediction
{
    string Predict(Module model, Dictionary<string, string> sample);
}