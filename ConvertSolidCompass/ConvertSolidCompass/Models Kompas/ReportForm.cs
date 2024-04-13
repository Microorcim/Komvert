using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class ReportForm
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte[] XmlFile { get; set; } = null!;

    public byte[]? Preview { get; set; }

    public int CatalogId { get; set; }

    public int Number { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ReportCatalog Catalog { get; set; } = null!;
}
