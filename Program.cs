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
        var model = ModulePipeline.FirstPipeline(strings);
        bool FileOrInput = Node.NodePath(strings);
        if(FileOrInput)
        {
            BatchModePipeline batchModePipeline = new BatchModePipeline();
            batchModePipeline.FilePipeline(args, model);
        }
        else
        {
            InteractiveInputPipeline interactiveInputPipeline = new InteractiveInputPipeline();
            interactiveInputPipeline.InputPipeline(args, model);
        }
            
    }
}