using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Techvalue
{
    public int Id { get; set; }

    public int ColumnId { get; set; }

    public string RecordId { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual Techcolum Column { get; set; } = null!;

    public virtual Record Record { get; set; } = null!;
}
