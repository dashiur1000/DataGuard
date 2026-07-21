using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces;
interface IParser
{
    List<Dictionary<string, string>> DictionaryParser(string[] lines);
}