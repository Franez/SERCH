using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EncEncargo
{
    public string UperId { get; set; } = null!;

    public short EncFolio { get; set; }

    public int? EncAuxTemplate { get; set; }

    public int? EncAuxCanTemp { get; set; }

    public string? TipEncCod { get; set; }

    public string? EncDocIngEnc { get; set; }

    public string? EstEncCod { get; set; }

    public string EstEncDes { get; set; } = null!;

    public int? EncDelCod { get; set; }

    public string? DurEncCod { get; set; }

    public string? AccEncCod { get; set; }

    public DateTime? EncFecEnc { get; set; }

    public int? EncFunCodIng { get; set; }

    public DateTime? EncFunTimeIng { get; set; }

    public decimal? EncDocFolio { get; set; }

    public string? EncDocGenEnc { get; set; }

    public int? EncOrgGenEnc { get; set; }

    public short? EncOrgCod { get; set; }

    public string? EncCausaNro { get; set; }

    public string? EncRitNro { get; set; }

    public DateTime? EncCausaFec { get; set; }

    public string? EncDetCal { get; set; }

    public string? EncEfecCod { get; set; }

    public string? EncCumCod { get; set; }

    public string? EncDebeCod { get; set; }

    public string? EncUniCod { get; set; }

    public short? EncTipo { get; set; }

    public short? EncNacTipo { get; set; }

    public string? EncObs { get; set; }

    public short? EncVigencia { get; set; }

    public string? EncIndexConCat { get; set; }

    public string? EncIndexInvConCat { get; set; }

    public string? EncDocOficio { get; set; }
}
