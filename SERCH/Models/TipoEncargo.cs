using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoEncargo
{
    public string TipEncCod { get; set; } = null!;

    public string? TipEncDes { get; set; }

    public short? TipEncVig { get; set; }

    public short? TipEncTipo { get; set; }

    public short? TipEncInt { get; set; }

    public short? TipEncDet { get; set; }
}
