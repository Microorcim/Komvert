using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Image
{
    public string Id { get; set; } = null!;

    public string ApparatusId { get; set; } = null!;

    public string? UgoReference { get; set; }

    public short? Type { get; set; }

    public virtual Apparatus Apparatus { get; set; } = null!;

    public virtual ICollection<ClampsReference> ClampsReferences { get; set; } = new List<ClampsReference>();

    public virtual ICollection<PartsReference> PartsReferences { get; set; } = new List<PartsReference>();

    public virtual Ugo? UgoReferenceNavigation { get; set; }
}
