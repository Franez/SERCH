using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniIngresoArmasNew
{
    public string InpFolio { get; set; } = null!;

    public short InpArmaFolio { get; set; }

    public short? InpEspStatus { get; set; }

    public DateTime? Inparmafecinc { get; set; }

    public DateTime? InpArmaHraInc { get; set; }

    public string? InpEspMonCod { get; set; }

    public decimal? InpArmaVal { get; set; }

    public short? InpArmaCant { get; set; }

    public string? InpArmaSerie { get; set; }

    public short? Unicodmodarma { get; set; }

    public short? OculArmasCod { get; set; }

    public short? UniCodTipoArma { get; set; }

    public short? UniCodMarArma { get; set; }

    public string? InpArmaModify { get; set; }

    public string? InpArmaModQue { get; set; }

    public string? InpArmaFiscal { get; set; }

    public short? InpArmaInstitucion { get; set; }

    public string? InpArmaCunia { get; set; }

    public string? InpArmaDgmn { get; set; }

    public string? InpArmaDuenio { get; set; }

    public string? InpArmaPorte { get; set; }

    public string? InpArmaConsultaDgmn { get; set; }

    public short? UniCodCalArma { get; set; }

    public string? InpArmaCalle { get; set; }

    public string? InpArmaComuna { get; set; }

    public string? InpArmaNro { get; set; }

    public string? InpArmaDuenioNom { get; set; }

    public string? InpArmaLatitud { get; set; }

    public string? InpArmaLongitud { get; set; }

    public string? InpArmaUperid { get; set; }

    public short? InpArmaSerieEstado { get; set; }

    public string? InpArmaTxt { get; set; }

    public string? InpArmaRecup { get; set; }

    public short? TipoOrdenCod { get; set; }

    public short? UniPaiMarArma { get; set; }

    public DateTime? UniFchIngArma { get; set; }

    public int? UniFunIngArma { get; set; }
}
