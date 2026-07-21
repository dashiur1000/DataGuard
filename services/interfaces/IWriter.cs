using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IWriter
{
    List<string> Write(string[] str, string file);
}