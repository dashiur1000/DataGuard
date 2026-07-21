using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using DataGuard.services.interfaces;

namespace DataGuard.services.classes
{
    class CsvReader : IReader
    {
        public string[] ReadFile(string file)
        {
            string[] fileText = File.ReadAllLines(file);

            return fileText;
        }
    }
}
