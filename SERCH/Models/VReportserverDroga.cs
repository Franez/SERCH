using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VReportserverDroga
{
    public string FolioInterno { get; set; } = null!;

    public DateTime? FechaRecepcion { get; set; }

    public string? FolioNacional { get; set; }

    public DateTime? FechaInformada { get; set; }

    public string CodUnidad { get; set; } = null!;

    public string? CodRegion { get; set; }

    public string? Unidad { get; set; }

    public string? CodJefatura { get; set; }

    public string Jefatura { get; set; } = null!;

    public string? CodPrefectura { get; set; }

    public string Prefectura { get; set; } = null!;

    public string? Droga { get; set; }

    public string? Medida { get; set; }

    public string? Estado { get; set; }

    public decimal? Nue { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? AvaluoUnitario { get; set; }

    public decimal? Avaluo { get; set; }

    public string? Delito { get; set; }
}
