using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Record
{
    public string Id { get; set; } = null!;

    public int TableId { get; set; }

    public int Number { get; set; }

    public string Group { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Gost { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentForm { get; set; }

    public string? Okp { get; set; }

    public int? SupplierId { get; set; }

    public short? Kind { get; set; }

    public double Mass { get; set; }

    public short Available { get; set; }

    public short Purchasable { get; set; }

    public string? TextHelp { get; set; }

    public byte[]? GraphHelp { get; set; }

    public double Length { get; set; }

    public double Width { get; set; }

    public double Diameter { get; set; }

    public double Hight { get; set; }

    public double RiseMin { get; set; }

    public double RiseMax { get; set; }

    public int? ColorInd { get; set; }

    public int? OtherFieldInt { get; set; }

    public short? OtherFieldName { get; set; }

    public virtual ICollection<Apparatus> Apparatuses { get; set; } = new List<Apparatus>();

    public virtual ICollection<Cable> Cables { get; set; } = new List<Cable>();

    public virtual ICollection<Comprise> Comprises { get; set; } = new List<Comprise>();

    public virtual ICollection<Fastener> Fasteners { get; set; } = new List<Fastener>();

    public virtual ICollection<Link> Links { get; set; } = new List<Link>();

    public virtual ICollection<Lug> Lugs { get; set; } = new List<Lug>();

    public virtual ICollection<Metalvalue> Metalvalues { get; set; } = new List<Metalvalue>();

    public virtual ICollection<ModelReference> ModelReferences { get; set; } = new List<ModelReference>();

    public virtual ICollection<OtherProduce> OtherProduces { get; set; } = new List<OtherProduce>();

    public virtual ICollection<Sheathe> Sheathes { get; set; } = new List<Sheathe>();

    public virtual Supplier? Supplier { get; set; }

    public virtual Table Table { get; set; } = null!;

    public virtual ICollection<Techvalue> Techvalues { get; set; } = new List<Techvalue>();

    public virtual ICollection<Texthelp> Texthelps { get; set; } = new List<Texthelp>();
}
