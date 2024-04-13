using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();
}
