using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class ModelsPlk
{
    public string Id { get; set; } = null!;

    public int TableId { get; set; }

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public int? Code1 { get; set; }

    public int? Code2 { get; set; }

    public byte[]? Data { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<KpostoGoPlk> KpostoGoPlks { get; set; } = new List<KpostoGoPlk>();

    public virtual ICollection<LpapparatusPlk> LpapparatusPlks { get; set; } = new List<LpapparatusPlk>();

    public virtual Table Table { get; set; } = null!;
}
