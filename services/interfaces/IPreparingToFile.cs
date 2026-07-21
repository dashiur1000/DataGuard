using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces
{
    interface IPreparingToFile
    {
        List<string> Preparing(List<Dictionary<string, string>> sample, string predict);
    }
}
