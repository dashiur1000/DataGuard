using DataGuard.services.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IModule
{
    ModuleCreator Train(List<Dictionary<string, string>> rows, string targetColumn);
}