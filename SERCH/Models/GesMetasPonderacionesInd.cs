using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesMetasPonderacionesInd
{
    public short GesMetaCod { get; set; }

    public short GesMetaAno { get; set; }

    public string GesMetaUnidad { get; set; } = null!;

    public short GesMetaIndCod { get; set; }

    public decimal? GesMetaIndPond { get; set; }
}
