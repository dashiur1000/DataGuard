using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    /// <summary>
    /// the orchestrator that in charge of the module creating
    /// </summary>
    internal class ModuleCreator
    {

        void Create()
        {
            string filePath = "./input/Buys_Computer_Test.csv"; //TODO: Change the path
            CsvReader csvReader = new CsvReader();

            string[] fileText = csvReader.ReadFile(filePath);




        }


    }
}
