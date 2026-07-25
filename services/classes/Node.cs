using System;
using System.Collections.Generic;
using System.Text;

namespace DataGuard.services.classes
{
    class Node
    {
        public static bool NodePath(string[] args)
        {
            int count = args.Length;
            if (count == 1)
            {
                return false;
            }
            else if ( count == 2)
            {
                return true;
            }
            throw new ArgumentException($"1 or 2 file paths were not entered.");
        }
    }
}
