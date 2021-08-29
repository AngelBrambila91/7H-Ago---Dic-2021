using System;
using System.Diagnostics;
using System.IO;

namespace TraceAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            // write to a text
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            // text write sid buffered, so we call flush()
            Trace.AutoFlush = true;
            Debug.WriteLine("Debug says, I am watching you ... ");
            Trace.WriteLine("Trace says, I am watching you ... ");

            // TDD
        }
    }
}
