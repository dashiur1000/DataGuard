using DataGuard.services.classes;
using DataGuard.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.pipelines
{
    class InteractiveInputPipeline
    {
        public bool InputPipeline(string[] args, Module model)
        {
            IPrediction prediction = new Predicted();
            InputSample inputSample = new InputSample();
            while (true)
            {
                Dictionary<string, string>? sample = inputSample.input(model);
                if(sample == null)
                {
                    break;
                }
                string predictResult = prediction.Predict(model, sample);
                Console.WriteLine($"Prediction: {predictResult}");
            }
            
            return true;
        }

    }
}
