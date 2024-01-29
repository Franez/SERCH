using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniSeguridadPersona
{
    public string InpFolio { get; set; } = null!;

    public string SpperId { get; set; } = null!;

    public string? SpnomPer { get; set; }

    public string? SpapePat { get; set; }

    public string? SpapeMat { get; set; }

    public short? SptipSeg { get; set; }

    public string? SpconPer { get; set; }
}
