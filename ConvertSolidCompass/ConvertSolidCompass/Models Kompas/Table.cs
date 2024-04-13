using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Table
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string Name { get; set; } = null!;

    public short Class { get; set; }

    public int Ininfo { get; set; }

    public int Isequal { get; set; }

    public int Fromlist { get; set; }

    public short Unit { get; set; }

    public int? ColorInd { get; set; }

    public virtual ICollection<Metalscolumn> Metalscolumns { get; set; } = new List<Metalscolumn>();

    public virtual ICollection<ModelsPlk> ModelsPlks { get; set; } = new List<ModelsPlk>();

    public virtual Hierarchy Parent { get; set; } = null!;

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();

    public virtual ICollection<Techcolum> Techcolums { get; set; } = new List<Techcolum>();

    public virtual ICollection<TexthelpTb> TexthelpTbs { get; set; } = new List<TexthelpTb>();
}
