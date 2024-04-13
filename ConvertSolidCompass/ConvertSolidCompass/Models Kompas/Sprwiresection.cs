using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Sprwiresection
{
    public int Id { get; set; }

    public double Section { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
