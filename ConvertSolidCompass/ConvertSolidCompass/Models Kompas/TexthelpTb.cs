using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class TexthelpTb
{
    public int Id { get; set; }

    public int TableId { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? PdfFile { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Table Table { get; set; } = null!;
}
