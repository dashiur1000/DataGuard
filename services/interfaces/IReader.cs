using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IReader
{
    string[] ReadFile(string file);
}