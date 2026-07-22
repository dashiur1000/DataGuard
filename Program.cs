using DataGuard.services.classes;
using DataGuard.services.pipelines;
using DataGuard.testing;
using System;
namespace DataGuard;
class Program
{
    static void Main(string[] args)
    {
        string[] strings = args;
        ModulePipeline.FirstPipeline(strings);
        bool FileOrInput = Node.NodePath(strings);
        if(FileOrInput)
        {
            
        }
        else
        {

        }
            
    }
}