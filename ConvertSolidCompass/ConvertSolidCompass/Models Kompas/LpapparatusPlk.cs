using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class LpapparatusPlk
{
    public string Id { get; set; } = null!;

    public short? Type { get; set; }

    public short? Islogical { get; set; }

    public string ModelId { get; set; } = null!;

    public string? KtmKta { get; set; }

    public string? Fullname { get; set; }

    public string? Voltage { get; set; }

    public string? Addrbegin { get; set; }

    public string? Addrend { get; set; }

    public string? Mask { get; set; }

    public short? Dimension { get; set; }

    public string? Pzone { get; set; }

    public string? Group { get; set; }

    public string? Gost { get; set; }

    public string? Comments { get; set; }

    public virtual ModelsPlk Model { get; set; } = null!;
}
