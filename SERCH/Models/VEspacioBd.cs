using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VEspacioBd
{
    public string Tabla { get; set; } = null!;

    public string? Esquema { get; set; }

    public long? NumeroDeFilas { get; set; }

    public decimal? TotalEspacioMb { get; set; }

    public decimal? EspacioUtilizadoMb { get; set; }

    public decimal? EspacioNoUtilizadoMb { get; set; }
}
