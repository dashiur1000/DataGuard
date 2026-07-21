using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IWriter
{
    void Write(string[] str, string file);
}