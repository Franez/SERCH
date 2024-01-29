using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpAmpliacionPlazo
{
    public string InpFolio { get; set; } = null!;

    public short InpAmpFolio { get; set; }

    public short? InpAmpEstado { get; set; }

    public int? InpAmpFunRut { get; set; }

    public DateTime? InpAmpFecha { get; set; }

    public DateTime? InpAmpFecFin { get; set; }

    public short? InpAmpDiasPlazo { get; set; }

    public string? InpAmpFisId { get; set; }

    public string? InpAmpObs { get; set; }

    public string? InpAmpUsuIns { get; set; }

    public string? InpAmpUsuUpd { get; set; }

    public string? InpAmpWrkIns { get; set; }

    public string? InpAmpWrkUpd { get; set; }

    public string? InpAmpUniIns { get; set; }

    public string? InpAmpUniUpd { get; set; }

    public DateTime? InpAmpFecIns { get; set; }

    public DateTime? InpAmpFecUpd { get; set; }
}
