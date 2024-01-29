using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniAuditorium
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public DateTime GesUniIngFec { get; set; }

    public short GesUniIngCorr { get; set; }

    public int? GesUniIngFunRut { get; set; }

    public DateTime? GesUniIngDateTime { get; set; }

    public string? GesUniIngIp { get; set; }
}
