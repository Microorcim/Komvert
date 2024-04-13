using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class TewClassification
{
    public int ClaId { get; set; }

    public string ClaName { get; set; } = null!;

    public int? ClaVersion { get; set; }

    public string ClaSwdefaultpartname { get; set; } = null!;

    public string ClaTwoddefaultpartname { get; set; } = null!;

    public string ClaSymbolwiringpartname { get; set; } = null!;

    public DateTime? ClaCreationdate { get; set; }

    public DateTime? ClaModificationdate { get; set; }

    public int? ClaDatatype { get; set; }

    public string ClaModifiedby { get; set; } = null!;
}
