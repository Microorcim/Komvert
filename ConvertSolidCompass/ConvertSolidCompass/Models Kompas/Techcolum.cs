using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Techcolum
{
    public int Id { get; set; }

    public int TableId { get; set; }

    public int ColumnNameId { get; set; }

    public short Ininfo { get; set; }

    public short Isequal { get; set; }

    public short Fromlist { get; set; }

    public virtual TechcolumName ColumnName { get; set; } = null!;

    public virtual Table Table { get; set; } = null!;

    public virtual ICollection<Techvalue> Techvalues { get; set; } = new List<Techvalue>();
}
