using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EndososBrain
{
    public string FolioInterno { get; set; } = null!;

    public short NumeroEndoso { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public short? DiasPlazo { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? Observaciones { get; set; }

    public string? Unidad { get; set; }

    public int? RutAsigna { get; set; }

    public string? NombreAsigna { get; set; }

    public string? ProcesoOfanAsigna { get; set; }

    public string? PerfilAsigna { get; set; }

    public int? RutRecibe { get; set; }

    public string? NombreRecibe { get; set; }

    public string? ProcesoOfanRecibe { get; set; }

    public string? PerfilRecibe { get; set; }

    public string? EstadoEndoso { get; set; }
}
