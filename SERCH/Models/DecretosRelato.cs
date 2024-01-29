using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosRelato
{
    public string InpFolio { get; set; } = null!;

    public string? Delito { get; set; }

    public string? Decreto { get; set; }

    public string? Comuna { get; set; }

    public string? Relato { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public DateTime? FechaInforme { get; set; }
}
