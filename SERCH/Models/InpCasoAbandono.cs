using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoAbandono
{
    public string InpFolio { get; set; } = null!;

    public short AbanCod { get; set; }

    public string AbanDes { get; set; } = null!;

    public string? InpAbanObs { get; set; }

    public string? InpAbanFunIns { get; set; }

    public string? InpAbanFunIp { get; set; }

    public DateTime? InpAbanFchIns { get; set; }

    public string? InpAbanFunUpd { get; set; }

    public string? InpAbanFunIpupd { get; set; }

    public DateTime? InpAbanFchUpd { get; set; }
}
