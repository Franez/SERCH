using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesAreasPonderacion
{
    public short GesAreaCod { get; set; }

    public short GesAreaAno { get; set; }

    public string GesAreaUnidad { get; set; } = null!;

    public decimal? GesAreaPond { get; set; }
}
