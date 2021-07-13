using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TinyVM
{
    public class VirtualMachineMemorySection
    {
        private readonly byte[] memory;

        public byte this[int offset]
        {
            get => memory[offset];
            set => memory[offset] = value;
        }

        public int Length => memory.Length;

        public Span<byte> this[int offset, int count] => memory.AsSpan(offset, count);
        public Span<byte> this[Range range] => this[range.Start.Value, range.End.Value - range.Start.Value];

        public Span<long> Long => MemoryMarshal.Cast<byte, long>(Byte);
        public Span<ulong> ULong => MemoryMarshal.Cast<byte, ulong>(Byte);
        public Span<int> Int => MemoryMarshal.Cast<byte, int>(Byte);
        public Span<uint> UInt => MemoryMarshal.Cast<byte, uint>(Byte);
        public Span<short> Short => MemoryMarshal.Cast<byte, short>(Byte);
        public Span<ushort> UShort => MemoryMarshal.Cast<byte, ushort>(Byte);
        public Span<sbyte> SByte => MemoryMarshal.Cast<byte, sbyte>(Byte);
        public Span<char> Char => MemoryMarshal.Cast<byte, char>(Byte);
        public Span<byte> Byte => new(memory);

        public unsafe ref T GetRef<T>(int offset) where T : unmanaged => ref MemoryMarshal.GetReference(MemoryMarshal.Cast<byte, T>(memory.AsSpan(offset, sizeof(T))));

        internal VirtualMachineMemorySection(int size)
        {
            memory = new byte[size];
        }
    }
}
