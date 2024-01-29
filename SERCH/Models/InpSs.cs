using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpSs
{
    public string InpFolio { get; set; } = null!;

    public short InpSucfolio { get; set; }

    public string? InpSucComCod { get; set; }

    public string? InpSucCalleCod { get; set; }

    public short? InpSucTipCalleCod { get; set; }

    public string? InpSucNroDir { get; set; }

    public string? InpSucVilla { get; set; }

    public string? InpSucVillaCod { get; set; }

    public string? InpSucNroDpto { get; set; }

    public string? InpSucCalleAlt { get; set; }

    public string? InpSucIntCalleCod { get; set; }

    public string? LugSucCod { get; set; }

    public string? InpSucConcurre { get; set; }

    public DateTime? InpSucFecha { get; set; }

    public string? InpSucRelato { get; set; }

    public string? InpSucRegCod { get; set; }

    public DateTime? InpSucHora { get; set; }

    public string InpAsisteCarab { get; set; } = null!;

    public string? InpSitioSuceso { get; set; }

    public string? InpTipoSitiosuc { get; set; }

    public string? InpSsdirRec { get; set; }

    public string? InpSsdirAlt { get; set; }

    public short? InpSslugCod { get; set; }

    public short? InpSsldetCod { get; set; }

    public string? InpSslugar { get; set; }

    public string? InpSsdirLat { get; set; }

    public string? InpSsdirLong { get; set; }

    public string? InpSsinsPdi { get; set; }

    public string? InpSsdetInsPdi { get; set; }

    public short? InpSucEstado { get; set; }
}
