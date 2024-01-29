using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VehiculosAltomando
{
    public DateTime? MesAño { get; set; }

    public string? CodRegion { get; set; }

    public string? Unidad { get; set; }

    public string? Especie { get; set; }

    public string? DetalleEspecie { get; set; }

    public string? Estado { get; set; }

    public decimal? Cantidad { get; set; }
}
