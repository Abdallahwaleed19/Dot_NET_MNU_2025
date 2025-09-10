using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Filelogger : IDisposable
    {
        private readonly StreamWriter writer;

        public Filelogger(string filename)
        {
            writer = File.CreateText(filename);
        }

        public void LogMessage(string message)
        {
            writer.WriteLine(message);
        }

        public void Dispose()
        {
            writer.Close();
        }
    }
}
