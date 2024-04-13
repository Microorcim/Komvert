using System;
using System.Collections.Generic;

namespace ConvertSolidCompass.Models.Catalog;

/// <summary>
/// Database structure and content version
/// </summary>
public partial class TewVersion
{
    public int VerId { get; set; }

    public int VerReference { get; set; }

    public int? VerReferencedatas { get; set; }
}
