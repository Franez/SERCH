using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniIndCalculoDe
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public short GesUniIndCod { get; set; }

    public int GesUniDesCod { get; set; }

    public string? GesUniDesIndCalc { get; set; }

    public decimal? GesUniDesIndValor { get; set; }
}
