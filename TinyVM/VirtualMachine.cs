using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TinyVM
{
    public class VirtualMachine
    {
        public VirtualMachineMemory Memory { get; } = new();
        public VirtualMachineRegisters Registers { get; } = new();

        public bool LoadProgram(Span<byte> data)
        {
            if (data.Length > Memory.Program.Length)
            {
                return false;
            }

            data.CopyTo(Memory.Program.Byte);

            return true;
        }
    }
}
