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

        public unsafe ref T Get<T>(int offset) where T : unmanaged => ref MemoryMarshal.GetReference(AsSpan<T>());

        internal VirtualMachineMemorySection(int size)
        {
            memory = new byte[size];
        }
        
        public Span<byte> AsSpan() => AsSpan<byte>();
        public Span<T> AsSpan<T>() where T : unmanaged => MemoryMarshal.Cast<byte, T>(memory.AsSpan());
        
        public static implicit operator Span<byte>(VirtualMachineMemorySection section) => section.AsSpan();
    }
}
