using System;
using System.Collections.Generic;

namespace ConvertSolidCompass.Models.Catalog;

public partial class TewTranslatedtext
{
    public int TraObjectid { get; set; }

    public int TraObjectno { get; set; }

    public string TraLanStrid { get; set; } = null!;

    public string TraStrobjectid { get; set; } = null!;

    public string? Tra0 { get; set; }

    public string? Tra1 { get; set; }
}
