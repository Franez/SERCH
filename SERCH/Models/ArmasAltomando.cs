using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ArmasAltomando
{
    public DateTime? MesAño { get; set; }

    public string? CodRegion { get; set; }

    public string? Unidad { get; set; }

    public string? TipoArma { get; set; }

    public string? Estado { get; set; }

    public int? Cantidad { get; set; }
}
