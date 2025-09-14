using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class FileProcessor
    {
        public async Task ReadFileAsync()
        {
            Console.WriteLine("Reading file...");
            await Task.Delay(2000); 
            Console.WriteLine("File read complete");
        }

        public async Task AnalyzeFileAsync()
        {
            Console.WriteLine("Analyzing file...");
            await Task.Delay(1000); 
            Console.WriteLine("File analysis complete");
        }
    }
}
