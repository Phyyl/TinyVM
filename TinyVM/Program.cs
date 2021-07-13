using System;
using System.Runtime.InteropServices;

namespace TinyVM
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualMachine vm = new();

            var x = vm.Memory.Ram[2..3][0..];
        }
    }
}
