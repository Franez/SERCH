using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpPlasCarro
{
    public int InpPlasfolio { get; set; }

    public string CarrPolId { get; set; } = null!;

    public short? InpPlascarrNroFun { get; set; }

    public int? InpPlascarrKmIni { get; set; }

    public int? InpPlascarrKmFin { get; set; }

    public decimal? InpPlascarrLts { get; set; }

    public string? InpPlascarrUni { get; set; }
}
