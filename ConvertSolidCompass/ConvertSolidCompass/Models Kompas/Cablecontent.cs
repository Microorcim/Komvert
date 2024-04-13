using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Cablecontent
{
    public string Id { get; set; } = null!;

    public string CableId { get; set; } = null!;

    public string ParentId { get; set; } = null!;

    public short Screenortwist { get; set; }

    public string Name { get; set; } = null!;

    public virtual Cable Cable { get; set; } = null!;

    public virtual ICollection<Wire> Wires { get; set; } = new List<Wire>();
}
