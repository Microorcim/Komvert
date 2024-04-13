using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class TechcolumName
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Sprtechvalue> Sprtechvalues { get; set; } = new List<Sprtechvalue>();

    public virtual ICollection<Techcolum> Techcolums { get; set; } = new List<Techcolum>();
}
