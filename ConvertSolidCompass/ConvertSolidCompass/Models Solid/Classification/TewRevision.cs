using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

/// <summary>
/// Revisions
/// </summary>
public partial class TewRevision
{
    public int RevNo { get; set; }

    public int RevObjId { get; set; }

    public DateTime? RevCreationdate { get; set; }

    public string? RevCreationname { get; set; }

    public DateTime? RevVerificationdate { get; set; }

    public string? RevVerificationname { get; set; }

    public DateTime? RevValidationdate { get; set; }

    public string? RevValidationname { get; set; }

    public int? RevRevno { get; set; }

    public string? RevTag { get; set; }
}
