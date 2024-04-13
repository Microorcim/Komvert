using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class ClampsReference
{
    public string Id { get; set; } = null!;

    public string ImageId { get; set; } = null!;

    public string? ClampId { get; set; }

    public int? UgoclampId { get; set; }

    public virtual Image Image { get; set; } = null!;
}
