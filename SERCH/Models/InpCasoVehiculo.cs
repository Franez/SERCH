using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoVehiculo
{
    public string InpFolio { get; set; } = null!;

    public short InpVehFolio { get; set; }

    public short? MarVehCod { get; set; }

    public short? TvhCod { get; set; }

    public short? ColCod { get; set; }

    public string? InpVehModelo { get; set; }

    public string? InpVehPatente { get; set; }

    public short? InpVehAnio { get; set; }

    public decimal? InpVehValor { get; set; }

    public DateTime? InpVehFec { get; set; }

    public string? InpVehObs { get; set; }

    public short? InpVehStatus { get; set; }

    public string? InpVehFunIns { get; set; }

    public DateTime? InpVehHrsIns { get; set; }

    public string? InpVehIpins { get; set; }

    public string? InpVehFunUpd { get; set; }

    public DateTime? InpVehHrsUpd { get; set; }

    public string? InpVehIpupd { get; set; }

    public string? InpVehNroCha { get; set; }

    public string? InpVehNroMot { get; set; }

    public string? InpVehClonado { get; set; }

    public string? InpVehUsDel { get; set; }

    public string? InpVehEnc { get; set; }

    public string? InpVehActEnt { get; set; }

    public decimal? InpVehNue { get; set; }

    public string? InpVehMonCod { get; set; }
}
