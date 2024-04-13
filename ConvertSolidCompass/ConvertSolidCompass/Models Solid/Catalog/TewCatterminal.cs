using System;
using System.Collections.Generic;

namespace ConvertSolidCompass.Models.Catalog;

public partial class TewCatterminal
{
    public int CatNo { get; set; }

    public int CatCaeNo { get; set; }

    public Guid CatCreUid { get; set; }

    public string? CatTxt { get; set; }

    public int? CatConnectionnb { get; set; }

    public string? CatMnemo { get; set; }

    public double? CatMaxsection { get; set; }

    public string? CatMaxgauge { get; set; }

    public double? CatMinsection { get; set; }

    public string? CatMingauge { get; set; }

    public int? CatFlowdirectiontype { get; set; }

    public string? CatTtycode { get; set; }
}
