using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Sprlugdiameter
{
    public int Id { get; set; }

    public double Diameter { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
