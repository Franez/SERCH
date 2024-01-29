using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniCalculoIndicadoresDe
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public short MetasCod { get; set; }

    public short GesIndCod { get; set; }

    public int GesUniDesCod { get; set; }

    public string? GesUniDesCalc { get; set; }

    public decimal? GesUniDesValor { get; set; }
}
