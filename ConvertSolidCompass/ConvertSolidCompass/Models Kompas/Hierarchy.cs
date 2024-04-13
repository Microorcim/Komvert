using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Hierarchy
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string Name { get; set; } = null!;

    public short Number { get; set; }

    public int? ColorInd { get; set; }

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
