using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class GoElementsPlk
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte[]? Data { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<KpostoGoPlk> KpostoGoPlks { get; set; } = new List<KpostoGoPlk>();
}
