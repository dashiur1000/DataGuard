using DataGuard.services.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.testing
{
    public class testingProgram
    {
        public static void Test()
        {

            var inputData = new List<Dictionary<string, string>>
                {


                    new() { { "Weather", "Sunny" },    { "Temp", "Hot" },  { "Wind", "Weak" },   { "Play", "No" } },
                    new() { { "Weather", "Sunny" },    { "Temp", "Hot" },  { "Wind", "Strong" }, { "Play", "No" } },
                    new() { { "Weather", "Sunny" },    { "Temp", "Mild" }, { "Wind", "Weak" },   { "Play", "Yes" } },
                    new() { { "Weather", "Cloudy" },   { "Temp", "Hot" },  { "Wind", "Weak" },   { "Play", "Yes" } },
                    new() { { "Weather", "Cloudy" },   { "Temp", "Cool" }, { "Wind", "Strong" }, { "Play", "Yes" } },
                    new() { { "Weather", "Rain" },     { "Temp", "Mild" }, { "Wind", "Weak" },   { "Play", "Yes" } },
                    new() { { "Weather", "Rain" },     { "Temp", "Cool" }, { "Wind", "Weak" },   { "Play", "Yes" } },
                    new() { { "Weather", "Rain" },     { "Temp", "Cool" }, { "Wind", "Strong" }, { "Play", "No" } },
                    new() { { "Weather", "Sunny" },    { "Temp", "Cool" }, { "Wind", "Strong" }, { "Play", "No" } },
                    new() { { "Weather", "Cloudy" },   { "Temp", "Mild" }, { "Wind", "Weak" },   { "Play", "Yes" } },
                    new() { { "Weather", "Rain" },     { "Temp", "Hot" },  { "Wind", "Weak" },   { "Play", "Yes" } },
                    new() { { "Weather", "Sunny" },    { "Temp", "Mild" }, { "Wind", "Strong" }, { "Play", "No" } },
                    new() { { "Weather", "Cloudy" },   { "Temp", "Hot" },  { "Wind", "Strong" }, { "Play", "Yes" } },
                    new() { { "Weather", "Rain" },     { "Temp", "Mild" }, { "Wind", "Strong" }, { "Play", "No" } },
                    new() { { "Weather", "Sunny" },    { "Temp", "Cool" }, { "Wind", "Weak" },   { "Play", "Yes" } }


                };

            Module module = new Module();

            module.Train(inputData, "Play");

            foreach (var x in module.Cond) { Console.WriteLine($"k: {x.Key} | v: {x.Value}"); }

        }

    }
}
