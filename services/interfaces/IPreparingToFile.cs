using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.interfaces
{
    interface IPreparingToFile
    {
        List<string> Preparing(string[] lines, string predict, NaiveBayesModel model);
    }
}
