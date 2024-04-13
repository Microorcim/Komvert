using System;
using System.Collections.Generic;

namespace ConvertSolidCompass.Models.Catalog;

public partial class TewCatreferencelink
{
    public int? CliObjecttype { get; set; }

    public int? CliElementtype { get; set; }

    public int CliCreParentid { get; set; }

    public int CliCreChildid { get; set; }
}
