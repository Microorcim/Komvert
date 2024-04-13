using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Metal
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Metalscolumn> Metalscolumns { get; set; } = new List<Metalscolumn>();
}
