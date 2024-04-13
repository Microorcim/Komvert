using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Ugo
{
    public string Id { get; set; } = null!;

    public byte[]? Ugo1 { get; set; }

    public byte[]? Image { get; set; }

    public int BugoId { get; set; }

    public string Name { get; set; } = null!;

    public int? Number { get; set; }

    public string? Description { get; set; }

    public byte[]? Icon { get; set; }

    public short? Type { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Bugo Bugo { get; set; } = null!;

    public virtual ICollection<FastenerImage> FastenerImages { get; set; } = new List<FastenerImage>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<OtherProduce> OtherProduces { get; set; } = new List<OtherProduce>();
}
