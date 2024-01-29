using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesPeriodoUnidad
{
    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public string GesUnidadPeriodo { get; set; } = null!;

    public short? GesUniPerActivo { get; set; }
}
