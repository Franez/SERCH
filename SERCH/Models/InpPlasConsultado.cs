using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpPlasConsultado
{
    public int InpPlasfolio { get; set; }

    public short InpPlasconNro { get; set; }

    public string? InpPlasconPerId { get; set; }

    public string? InpPlasconDocNro { get; set; }

    public short? InpPlasconDocPai { get; set; }

    public string? InpPlasconDocTipo { get; set; }

    public DateTime? InpPlasconHora { get; set; }

    public DateTime? InpPlasconFch { get; set; }

    public short? InpPlasdetHrs { get; set; }

    public short? InpPlasdetMin { get; set; }

    public short? InpPlasconAntec { get; set; }

    public short? InpPlasconDet { get; set; }

    public short? InpPlasconDetCua { get; set; }

    public int? MotDetCod { get; set; }

    public string? InpPlasconComCod { get; set; }

    public string? InpPlasconCalleCod { get; set; }

    public short? InpPlasconTipoCalle { get; set; }

    public string? InpPlasconVillaCod { get; set; }

    public string? InpPlasconCalleInt { get; set; }

    public string? InpPlasconNroCalle { get; set; }

    public string? InpPlasconNroDpto { get; set; }

    public short? InpPlasconRelev { get; set; }

    public short? InpPlasconCauPen { get; set; }

    public DateTime? InpPlasconDetFecIni { get; set; }

    public DateTime? InpPlasconDetFecFin { get; set; }

    public short? InpPlasconDetHrsIni { get; set; }

    public short? InpPlasconDetMinIni { get; set; }

    public short? InpPlasconDetHrsFin { get; set; }

    public short? InpPlasconDetMinFin { get; set; }

    public short? InpPlasconDetEstado { get; set; }

    public DateTime? InpPlasconDetHoraIni { get; set; }

    public DateTime? InpPlasconDetHoraFin { get; set; }

    public string? InpPlasconDetParteNro { get; set; }

    public string? InpPlasconFunIns { get; set; }

    public string? InpPlasconWrkIns { get; set; }

    public DateTime? InpPlasconFecIns { get; set; }

    public string? InpPlasconFunUpd { get; set; }

    public string? InpPlasconWrkUpd { get; set; }

    public DateTime? InpPlasconFecUpd { get; set; }

    public string? InpPlasconRel { get; set; }

    public short InpPlasconLin { get; set; }

    public int? DelCod { get; set; }

    public string? InpPlasVillaPoblaTxt { get; set; }

    public short? MotDetFla { get; set; }
}
