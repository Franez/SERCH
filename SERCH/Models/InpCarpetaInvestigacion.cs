using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCarpetaInvestigacion
{
    public decimal InpCarpNro { get; set; }

    public string? InpCarpDesc { get; set; }

    public DateTime? InpCarpFecIns { get; set; }

    public string? InpCarpRuc { get; set; }

    public int? InpCarpFunIns { get; set; }

    public string? InpCarpUniIns { get; set; }

    public string? InpCarpDetalle { get; set; }

    public decimal? InpCarpInvFolio { get; set; }

    public string? InpCarpUsuIns { get; set; }

    public DateTime? InpCarpFecReaIns { get; set; }

    public string? InpCarpWrkIns { get; set; }

    public string? InpCarpFunUpd { get; set; }

    public string? InpCarpWrkUpd { get; set; }

    public DateTime? InpCarpFecUpd { get; set; }

    public string? InpCarpUniAlma { get; set; }

    public DateTime? InpCarpFecHch { get; set; }
}
