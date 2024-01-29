using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpPideCuentum
{
    public string InpFolio { get; set; } = null!;

    public short InpPideFolio { get; set; }

    public string? InpPideDocTipo { get; set; }

    public string? InpPideDocNro { get; set; }

    public DateTime? InpPideDocFec { get; set; }

    public string? InpPideFisId { get; set; }

    public string? InpPideUniCod { get; set; }

    public int? InpPideFunRec { get; set; }

    public short? InpPideDiaPla { get; set; }

    public DateTime? InpPideVenFec { get; set; }

    public string? InpPideDetalles { get; set; }

    public string? InpPideObs { get; set; }

    public string? InpPideUsuIns { get; set; }

    public string? InpPideWrkIns { get; set; }

    public DateTime? InpPideFecIns { get; set; }

    public DateTime? InpPideCtaFecFing { get; set; }
}
