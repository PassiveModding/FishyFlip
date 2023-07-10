// <copyright file="FrameHeaderConverter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using FishyFlip.Models;
using PeterO.Cbor;

namespace FishyFlip.Tools.Cbor;

public class FrameHeaderConverter : ICBORToFromConverter<FrameHeader>
{
    public CBORObject ToCBORObject(FrameHeader cpod)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public FrameHeader FromCBORObject(CBORObject obj)
    {
        if (obj.Type != CBORType.Map)
        {
            throw new CBORException();
        }

        var ret = new FrameHeader();
        ret.Operation = obj["op"].AsInt32();
        ret.Type = obj["t"].AsString();
        return ret;
    }
}