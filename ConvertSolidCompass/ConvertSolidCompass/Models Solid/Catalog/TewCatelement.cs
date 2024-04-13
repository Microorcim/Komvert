using System;
using System.Collections.Generic;

namespace ConvertSolidCompass.Models.Catalog;

public partial class TewCatelement
{
    public int CaeNo { get; set; }

    public Guid CaeCreUid { get; set; }

    public string? CaeKeycode { get; set; }

    public string? CaeChannelgroup { get; set; }

    public string? CaeGroup { get; set; }

    public string? CaeChanneladdress { get; set; }

    public string CaeBlockname { get; set; } = null!;

    public int CaeBlockno { get; set; }

    public int CaeBlockctno { get; set; }
}
