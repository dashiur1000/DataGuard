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
                    new() { { "City", "Tel Aviv" }, { "Speed", "80" } },
                    new() { { "City", "Haifa" }, { "Speed", "100" } },
                    new() { { "City", "Tel Aviv" }, { "Speed", "90" } }
                };

            Module module = new Module();

            module.CalculateMoudle(inputData, "City");

        }

    }
}
