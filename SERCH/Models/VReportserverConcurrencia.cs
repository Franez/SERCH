using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VReportserverConcurrencia
{
    public string FolioInterno { get; set; } = null!;

    public string? TipoDecreto { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public int? TotalSs { get; set; }

    public int? TotalConcu { get; set; }

    public string TipoLugar { get; set; } = null!;

    public string EstadoSs { get; set; } = null!;

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public int? Delito { get; set; }
}
