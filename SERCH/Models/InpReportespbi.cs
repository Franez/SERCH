using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpReportespbi
{
    public decimal IdPbi { get; set; }

    public string? KeyEmbPbi { get; set; }

    public string? SourceHttpPbi { get; set; }

    public DateTime? DatePbi { get; set; }

    public short? ApliPerfilPbi { get; set; }
}
