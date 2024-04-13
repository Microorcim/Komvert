using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class KposPlk
{
    public string Id { get; set; } = null!;

    public string? Kpos { get; set; }

    public string? Codetypemodule { get; set; }

    public string Ktadefid { get; set; } = null!;

    public string? Namedef { get; set; }

    public string Gospiddef { get; set; } = null!;

    public string? Gonamedef { get; set; }

    public int? Numberoutsidecontact { get; set; }

    public string? Comments { get; set; }

    public virtual ICollection<KpostoGoPlk> KpostoGoPlks { get; set; } = new List<KpostoGoPlk>();
}
