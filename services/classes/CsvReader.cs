using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DataGuard.services.classes
{
    class CsvReader : IReader 
    {
        static string[] ReadFile(string path)
        {
            string[] fileText = File.ReadAllLines(path);

            return fileText;
        }
    }
}
