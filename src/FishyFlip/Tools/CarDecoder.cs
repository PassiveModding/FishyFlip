using FishyFlip.Events;

namespace FishyFlip.Tools
{
    internal class CarDecoder
    {
        private const int _cidV1BytesLength = 36;

        public event EventHandler<CreateCarEvent>? ProgressStatus;

        public Dictionary<string, byte[]> DecodeCar(byte[] bytes)
        {
            var blocks = new Dictionary<string, byte[]>();

            int bytesLength = bytes.Length;
            var header = DecodeReader(bytes);

            int start = header.Length + header.Value;

            while (start < bytesLength)
            {
                var body = DecodeReader(bytes[start..]);
                start += body.Length;

                var cidBytes = bytes[start..(start + _cidV1BytesLength)];
                var cid = Cid.Read(cidBytes);

                start += _cidV1BytesLength;
                blocks[cid] = bytes[start..(start + body.Value - _cidV1BytesLength)];
                this.ProgressStatus?.Invoke(this, new CreateCarEvent(cid, blocks[cid]));
                start += body.Value - _cidV1BytesLength;
            }

            return blocks;
        }

        private _DecodedBlock DecodeReader(byte[] bytes)
        {
            var a = new List<byte>();

            int i = 0;
            while (true)
            {
                byte b = bytes[i];

                i++;
                a.Add(b);
                if ((b & 0x80) == 0)
                {
                    break;
                }
            }

            return new _DecodedBlock(Decode(a), a.Count);
        }

        private class _DecodedBlock
        {
            public _DecodedBlock(int value, int length)
            {
                Value = value;
                Length = length;
            }

            public int Value { get; }
            public int Length { get; }
        }

        private int Decode(List<byte> b)
        {
            int r = 0;
            for (int i = 0; i < b.Count; i++)
            {
                int e = b[i];
                r = r + ((e & 0x7F) << (i * 7));
            }

            return r;
        }
    }
}
