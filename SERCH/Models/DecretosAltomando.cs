using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosAltomando
{
    public DateTime? Fecha { get; set; }

    public string? Unidad { get; set; }

    public string? CodRegion { get; set; }

    public string? Decreto { get; set; }

    public int? Cantidad { get; set; }
}
