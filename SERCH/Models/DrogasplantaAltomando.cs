using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DrogasplantaAltomando
{
    public DateTime? MesAño { get; set; }

    public string? CodRegion { get; set; }

    public string? Unidad { get; set; }

    public string? Droga { get; set; }

    public string? Medida { get; set; }

    public string? Estado { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Avaluo { get; set; }
}
