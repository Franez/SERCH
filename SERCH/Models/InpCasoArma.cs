using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoArma
{
    public string InpFolio { get; set; } = null!;

    public short InpArmFolio { get; set; }

    public short? TipArmCod { get; set; }

    public short? MarArmCod { get; set; }

    public int? InpArmCant { get; set; }

    public string? InpArmModelo { get; set; }

    public short? InpArmCalibre { get; set; }

    public short? InpArmCond { get; set; }

    public short? InpArmStatus { get; set; }

    public string? InpArmObs { get; set; }

    public decimal? InpArmNue { get; set; }

    public DateTime? InpArmFecInc { get; set; }

    public string? InpArmFunIns { get; set; }

    public string? InpArmFunUpd { get; set; }

    public DateTime? InpArmHrsIns { get; set; }

    public DateTime? InpArmHrsUpd { get; set; }

    public string? InpArmIpins { get; set; }

    public string? InpArmIpupd { get; set; }

    public string? InpArmUniIns { get; set; }

    public string? InpArmUniUpd { get; set; }

    public string? InpArmNroSer { get; set; }

    public short? InpArmExiNrS { get; set; }

    public string? InpArmaIns { get; set; }

    public string? InpArmEnc { get; set; }

    public string? InpArmMonCod { get; set; }
}
