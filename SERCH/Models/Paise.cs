using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Paise
{
    public short Paicod { get; set; }

    public string Painom { get; set; } = null!;

    public string PaiGen { get; set; } = null!;

    public string Contincod { get; set; } = null!;

    public short PaiFlag { get; set; }

    public string? PaiAbr { get; set; }

    public int? PaiMinCod { get; set; }

    public short? PaiCodTel { get; set; }
}
