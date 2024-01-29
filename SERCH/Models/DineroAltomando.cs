using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DineroAltomando
{
    public DateTime? MesAño { get; set; }

    public string? Unidad { get; set; }

    public string? CodRegion { get; set; }

    public string? Especie { get; set; }

    public string? Estado { get; set; }

    public decimal? AvaluoClp { get; set; }
}
