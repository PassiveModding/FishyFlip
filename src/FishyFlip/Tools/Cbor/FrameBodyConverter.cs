// <copyright file="FrameBodyConverter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using FishyFlip.Models;
using PeterO.Cbor;

namespace FishyFlip.Tools.Cbor;

public class FrameBodyConverter : ICBORToFromConverter<FrameBody>
{
    public CBORObject ToCBORObject(FrameBody cpod)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public FrameBody FromCBORObject(CBORObject obj)
    {
        if (obj.Type != CBORType.Map)
        {
            throw new CBORException();
        }

        var ret = new FrameBody();
        ret.Seq = obj["seq"].AsInt32();
        ret.Blocks = obj["blocks"].GetByteString();
        return ret;
    }
}