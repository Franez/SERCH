using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoDiligencia
{
    public string InpFolio { get; set; } = null!;

    public short InpDilNro { get; set; }

    public DateTime? InpDiliFec { get; set; }

    public DateTime? InpDiliHora { get; set; }

    public string? InpDiliTxt { get; set; }

    public string? InpDiliUniCod { get; set; }

    public decimal? InpDiliNumInf { get; set; }

    public short? InpDiliPropIni { get; set; }

    public short? InpDiliOrgCod { get; set; }

    public int? InpDiliOrgDetNro { get; set; }

    public string? InpDiliTipDoc { get; set; }

    public string? InpDiliNroDoc { get; set; }

    public short? InpUltCorrDoc { get; set; }

    public string? InpDiliRes { get; set; }

    public int? Inpdilifunjef { get; set; }
}
