using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyFlip.Events;

public class CreateCarEvent
{
    public CreateCarEvent(Cid cid, byte[] data)
    {
        Cid = cid;
        Data = data;
    }

    public Cid Cid { get; }
    public byte[] Data { get; }
}