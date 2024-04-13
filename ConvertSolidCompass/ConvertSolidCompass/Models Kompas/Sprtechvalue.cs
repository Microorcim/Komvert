using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Sprtechvalue
{
    public int Id { get; set; }

    public int ColumnNameId { get; set; }

    public string Techvalue { get; set; } = null!;

    public virtual TechcolumName ColumnName { get; set; } = null!;
}
