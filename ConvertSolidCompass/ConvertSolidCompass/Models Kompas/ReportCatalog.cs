using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class ReportCatalog
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string Name { get; set; } = null!;

    public int Number { get; set; }

    public virtual ICollection<ReportForm> ReportForms { get; set; } = new List<ReportForm>();
}
