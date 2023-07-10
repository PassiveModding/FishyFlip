// <copyright file="CidConverter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using FishyFlip.Models;
using PeterO.Cbor;

namespace FishyFlip.Tools.Cbor;

public class CidConverter : ICBORToFromConverter<Cid>
{
    public CBORObject ToCBORObject(Cid cpod)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public Cid FromCBORObject(CBORObject obj)
    {
        if (obj.Type != CBORType.Map)
        {
            throw new CBORException();
        }

        return Cid.Read(obj.GetByteString());
    }
}