using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesAreasPonderacionMeta
{
    public short GesAreaCod { get; set; }

    public short GesAreaAno { get; set; }

    public string GesAreaUnidad { get; set; } = null!;

    public short GesAreaMeta { get; set; }

    public short? GesAreaMetaTipo { get; set; }

    public decimal? GesAreaMetaPond { get; set; }
}
