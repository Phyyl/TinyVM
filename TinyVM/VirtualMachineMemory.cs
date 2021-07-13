using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TinyVM
{
    public class VirtualMachineMemory
    {
        public const int StackSize = 0x0100;
        public const int ProgramSize = 0x0400;
        public const int RamSize = 0x0F00;

        public VirtualMachineMemorySection Stack { get; } = new(StackSize);
        public VirtualMachineMemorySection Program { get; } = new(ProgramSize);
        public VirtualMachineMemorySection Ram { get; } = new(RamSize);
    }
}
