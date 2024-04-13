using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Metalvalue
{
    public int Id { get; set; }

    public int ColumnId { get; set; }

    public string RecordId { get; set; } = null!;

    public double Value { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Metalscolumn Column { get; set; } = null!;

    public virtual Record Record { get; set; } = null!;
}
