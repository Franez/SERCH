using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesMetasPonderacione
{
    public short GesMetaCod { get; set; }

    public short GesMetaAno { get; set; }

    public string GesMetaUnidad { get; set; } = null!;

    public short? GesMetaTipo { get; set; }

    public decimal? GesMetaPond { get; set; }
}
