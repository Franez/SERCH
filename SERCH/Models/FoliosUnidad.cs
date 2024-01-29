using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class FoliosUnidad
{
    public string? Unidad { get; set; }

    public string FolioInterno { get; set; } = null!;

    public string? TipoOrden { get; set; }

    public string? FolioNacional { get; set; }

    public string? FolioUnidad { get; set; }

    public DateTime? FechaInforme { get; set; }

    public int? RutFuncionario { get; set; }

    public string? Nombre { get; set; }
}
