using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Apparatus
{
    public string Id { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Part> Parts { get; set; } = new List<Part>();

    public virtual Record Record { get; set; } = null!;
}
