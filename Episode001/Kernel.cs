using System; //Console stuff (console.write)
using System.Collections.Generic; //Lists, Tables
using System.Text; //Advanced strings, ...
using Sys = Cosmos.System; //Core

namespace LarvaOS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }
        
        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
/*
 * File System 
 * Threading -> No supported | [Sleep] -> not implemented
 */ 