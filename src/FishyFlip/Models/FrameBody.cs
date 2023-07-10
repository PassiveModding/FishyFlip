using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyFlip.Models;

public class FrameBody
{
    public Ops[] Ops { get; set; }

    public int Seq { get; set; }

    public string Prev { get; set; }

    public string Repo { get; set; }

    public DateTime Time { get; set; }

    public byte[] Blocks { get; set; }

    public string Commit { get; set; }

    public bool Rebase { get; set; }

    public bool TooBig { get; set; }
}