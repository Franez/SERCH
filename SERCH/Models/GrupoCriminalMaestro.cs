using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GrupoCriminalMaestro
{
    public int GrupoCrimCodMa { get; set; }

    public int GrupoCrimAsoCodM { get; set; }

    public string? GrupoCrimDsc { get; set; }

    public string? GrupoCrimDscCod { get; set; }

    public short GrupoCrimVig { get; set; }

    public short? GrupoCrimVinc { get; set; }

    public DateTime? GrupoCrimIngSis { get; set; }
}
