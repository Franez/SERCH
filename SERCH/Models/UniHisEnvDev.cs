using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniHisEnvDev
{
    public string InpFolio { get; set; } = null!;

    public short UniFolHisEnvDev { get; set; }

    public string? UniEstEnvDev { get; set; }

    public DateTime? UniFecEnvDev { get; set; }

    public int? UniFunEnvDev { get; set; }
}
