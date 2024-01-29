using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCharla
{
    public decimal InpCharFolio { get; set; }

    public short? InpCharTipo { get; set; }

    public string? InpCharUniCod { get; set; }

    public DateTime? InpCharFecha { get; set; }

    public short? InpCharAnio { get; set; }

    public short? InpCharMes { get; set; }

    public short? InpCharSegCiu { get; set; }

    public short? InpCharPolExt { get; set; }

    public short? InpCharOrgCod { get; set; }

    public int? InpCharOrgDetCod { get; set; }

    public int? InpCharFunCargo { get; set; }

    public string? InpCharDetalle { get; set; }

    public decimal? InpCharInvFolio { get; set; }

    public string? InpCharFunIns { get; set; }

    public string? InpCharFunUpd { get; set; }

    public string? InpCharWrkIns { get; set; }

    public string? InpCharWrkUpd { get; set; }

    public DateTime? InpCharFecIns { get; set; }

    public DateTime? InpCharFecUpd { get; set; }
}
