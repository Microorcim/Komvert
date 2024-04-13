using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class PartsReference
{
    public string Id { get; set; } = null!;

    public string? ImageId { get; set; }

    public string? PartId { get; set; }

    public string TextfieldBco { get; set; } = null!;

    public virtual Image? Image { get; set; }
}
