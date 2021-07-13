using System.Runtime.InteropServices;

namespace TinyVM
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VirtualMachineRegister
    {
        [FieldOffset(0)] public long Long;
        [FieldOffset(0)] public ulong ULong;
        [FieldOffset(0)] public int Int;
        [FieldOffset(0)] public uint UInt;
        [FieldOffset(0)] public short Short;
        [FieldOffset(0)] public ushort UShort;
        [FieldOffset(0)] public sbyte SByte;
        [FieldOffset(0)] public byte Byte;
        [FieldOffset(0)] public char Char;
        
        public static implicit operator long(VirtualMachineRegister register) => register.Long;
        public static implicit operator ulong(VirtualMachineRegister register) => register.ULong;
        public static implicit operator int(VirtualMachineRegister register) => register.Int;
        public static implicit operator uint(VirtualMachineRegister register) => register.UInt;
        public static implicit operator short(VirtualMachineRegister register) => register.Short;
        public static implicit operator ushort(VirtualMachineRegister register) => register.UShort;
        public static implicit operator sbyte(VirtualMachineRegister register) => register.SByte;
        public static implicit operator byte(VirtualMachineRegister register) => register.Byte;
        public static implicit operator char(VirtualMachineRegister register) => register.Char;

        public static implicit operator VirtualMachineRegister(long value) => value;
        public static implicit operator VirtualMachineRegister(ulong value) => value;
        public static implicit operator VirtualMachineRegister(int value) => value;
        public static implicit operator VirtualMachineRegister(uint value) => value;
        public static implicit operator VirtualMachineRegister(short value) => value;
        public static implicit operator VirtualMachineRegister(ushort value) => value;
        public static implicit operator VirtualMachineRegister(sbyte value) => value;
        public static implicit operator VirtualMachineRegister(byte value) => value;
        public static implicit operator VirtualMachineRegister(char value) => value;
    }
}
