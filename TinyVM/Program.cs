using System;
using System.Runtime.InteropServices;

namespace TinyVM
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualMachine vm = new();
            
            vm.Run();
        }
    }
}
