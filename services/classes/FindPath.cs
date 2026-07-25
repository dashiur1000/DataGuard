using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    class FindPathInFile
    {
        public string FoundPath(string filename, params string[] dir)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo projectDir = Directory.GetParent(baseDir).Parent.Parent.Parent;
            string FullPath = Path.Combine(projectDir.FullName, Path.Combine(dir), filename);
            return FullPath;
        }
    }
}
