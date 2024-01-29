using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoEspecy
{
    public string InpFolio { get; set; } = null!;

    public short InpEspFolio { get; set; }

    public short? InpEspTipo { get; set; }

    public string? InpEspCod { get; set; }

    public string? InpEspDes { get; set; }

    public string? InpEspSerie { get; set; }

    public string? InpEspGrab { get; set; }

    public string MedUniCod { get; set; } = null!;

    public decimal? InpEspCant { get; set; }

    public decimal? InpEspVal { get; set; }

    public short? InpEspStatus { get; set; }

    public string? InpEspObs { get; set; }

    public decimal? InpEspNue { get; set; }

    public short? InpTipOrDenCod { get; set; }

    public string? InpRegCod { get; set; }

    public string? InpUnidadCod { get; set; }

    public string? InpEspTxt { get; set; }

    public short? UniEstCod { get; set; }

    public string? UniEspLevPor { get; set; }

    public string? UniEspEntPor { get; set; }

    public string? UniEspRemitida { get; set; }

    public string? InpEspEnc { get; set; }

    public string InpEspMonCod { get; set; } = null!;

    public string? UniEspNroCha { get; set; }

    public string? UniEspNroMot { get; set; }

    public string? UniEspImeicel { get; set; }

    public string? UniEspMacAddress { get; set; }

    public string? InpEspDsc { get; set; }

    public short? UniEstUltFotEsp { get; set; }

    public DateTime? InpEspFecInc { get; set; }

    public DateTime? InpEspHraInc { get; set; }

    public string? InpEspRecu { get; set; }

    public string? UniEspSdtingEnc { get; set; }

    public string? UniEspSdtcanEnc { get; set; }

    public string? UniEspSdtestEnc { get; set; }
}
