using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniOtrosDocumentosAdjunto
{
    public string InpFolio { get; set; } = null!;

    public short UniOtDnro { get; set; }

    public int UniOtDcorr { get; set; }

    public string? UniOtDext { get; set; }

    public string? UniOtDnom { get; set; }

    public byte[]? UniOtDocAdj { get; set; }
}
