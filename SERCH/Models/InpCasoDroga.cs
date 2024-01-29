using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoDroga
{
    public string InpFolio { get; set; } = null!;

    public short DrogCod { get; set; }

    public decimal InpDrogFolio { get; set; }

    public string? MedUniCod { get; set; }

    public short? InpDrogOvo { get; set; }

    public short? InpDrogStatus { get; set; }

    public decimal? InpDrogCan { get; set; }

    public decimal? InpDrogVal { get; set; }

    public DateTime? InpDrogFec { get; set; }

    public decimal? InpDrogNue { get; set; }

    public int? InpDrogUniCosto { get; set; }

    public short? OculDrogCod { get; set; }

    public short? InpDrogPaisOri { get; set; }

    public short? InpDrogPaisDes { get; set; }

    public string? InpDrogComCodOri { get; set; }

    public string? InpDrogComCodDes { get; set; }

    public string? InpDrogObs { get; set; }

    public string? InpDrogFunIns { get; set; }

    public string? InpDrogFunIp { get; set; }

    public DateTime? InpDrogFchIns { get; set; }

    public string? InpDrogFunUpd { get; set; }

    public string? InpDrogFunIpupd { get; set; }

    public DateTime? InpDrogFchUpd { get; set; }

    public short? InpDroEstCar { get; set; }

    public short? InpDroEntDes { get; set; }

    public string? InpDroCoor { get; set; }

    public string? InpDroPasFron { get; set; }

    public string? InpDroPasFronDet { get; set; }
}
