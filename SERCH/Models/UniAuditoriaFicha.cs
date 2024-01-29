using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAuditoriaFicha
{
    public string AudFicIdp { get; set; } = null!;

    public int AudFicFun { get; set; }

    public DateTime AudFicFec { get; set; }

    public string AudFicHor { get; set; } = null!;

    public string? AudFicIp { get; set; }
}
