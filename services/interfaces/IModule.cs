using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IModule
{
    module Train(List<Dictionary<string, string>> rows, string targetColumn);
}