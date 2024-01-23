using System;

namespace Ryujinx.Memory
{
    public sealed class WritableRegion : IDisposable
    {
        private readonly IWritableBlock _block;
        private readonly ulong _va;
        private readonly bool _tracked;

        private bool NeedsWriteback => _block != null;

        public Memory<byte> Memory { get; }

        public WritableRegion(IWritableBlock block, ulong va, Memory<byte> memory, bool tracked = false)
        {
            _block = block;
            _va = va;
            _tracked = tracked;
            Memory = memory;
        }

        public void Dispose()
        {
            if (NeedsWriteback)
            {
                if (_tracked)
                {
                    _block.Write(_va, Memory.Span);
                }
                else
                {
                    _block.WriteUntracked(_va, Memory.Span);
                }
            }
        }
    }
}
