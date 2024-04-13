using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConvertSolidCompass;

public partial class TewNode
{
    public int NodId { get; set; }

    public int? NodClaId { get; set; }

    public int? NodNodId { get; set; }

    public string? NodFamCode { get; set; }

    public int NodClauid { get; set; }

    public int? NodDepth { get; set; }

    public int? NodClauiddefault { get; set; }

    public string? NodPartname { get; set; }

    public int? NodDatatype { get; set; }

    public string? NodPartnametwod { get; set; }

    public string? NodSymbolwiringpartname { get; set; }

    public DateTime? NodCreationdate { get; set; }

    public DateTime? NodModificationdate { get; set; }

    public string? NodUdfilename { get; set; }

    public int? NodComponenttype { get; set; }

    public string? NodModifiedby { get; set; }

    [NotMapped]
    public virtual string? NodTranlatedName { get; set; }
}
