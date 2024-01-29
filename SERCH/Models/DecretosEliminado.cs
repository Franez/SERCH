using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosEliminado
{
    public string? FolioInterno { get; set; }

    public string? TipoMovimiento { get; set; }

    public string? Ruc { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public string? HoraMovimiento { get; set; }

    public int? RutEjecuta { get; set; }

    public string? NombreEjecuta { get; set; }

    public string? Unidad { get; set; }

    public string? Motivo { get; set; }

    public string? FolioNacionalUnidad { get; set; }

    public int? RutIngresa { get; set; }

    public string? NombreIngresa { get; set; }

    public string? UnidadIngresa { get; set; }
}
