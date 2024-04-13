using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Metalscolumn
{
    public int Id { get; set; }

    public int TableId { get; set; }

    public int MetalNameId { get; set; }

    public short Ininfo { get; set; }

    public short Isequal { get; set; }

    public short Fromlist { get; set; }

    public virtual Metal MetalName { get; set; } = null!;

    public virtual ICollection<Metalvalue> Metalvalues { get; set; } = new List<Metalvalue>();

    public virtual Table Table { get; set; } = null!;
}
