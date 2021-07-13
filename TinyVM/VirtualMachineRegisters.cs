using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TinyVM
{
    public struct VirtualMachineRegisters
    {
        public VirtualMachineRegister A;
        public VirtualMachineRegister B;
        public VirtualMachineRegister C;
        public VirtualMachineRegister D;
        public VirtualMachineRegister IP;
        public VirtualMachineRegister SP;
    }
}
