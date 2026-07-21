using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces
{
    internal interface IExport
    {
        bool ExportToFile(string file, List<string> data);
    }
}
