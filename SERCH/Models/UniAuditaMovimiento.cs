using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAuditaMovimiento
{
    public string InpFolio { get; set; } = null!;

    public short AudMovNro { get; set; }

    public string? AudMovTip { get; set; }

    public DateTime? AudMovFec { get; set; }

    public string? AudMovHor { get; set; }

    public int? AudMovFre { get; set; }

    public int? AudMovFso { get; set; }

    public string? AudMovObs { get; set; }

    public string? AudUniDes { get; set; }

    public short? AudGravMov { get; set; }

    public string? AudMovIp { get; set; }
}
