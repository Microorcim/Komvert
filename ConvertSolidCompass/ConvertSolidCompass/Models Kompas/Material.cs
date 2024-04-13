using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Wire> Wires { get; set; } = new List<Wire>();
}
