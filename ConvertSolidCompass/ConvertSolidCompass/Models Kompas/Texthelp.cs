using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Texthelp
{
    public int Id { get; set; }

    public string RecordId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte[]? PdfFile { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Record Record { get; set; } = null!;
}
