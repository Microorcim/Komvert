using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Sprrecname
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public short Class { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
