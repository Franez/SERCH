using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAuditorium
{
    public DateTime UniAudFecha { get; set; }

    public short UniAudHora { get; set; }

    public short UniAudMin { get; set; }

    public short UniAudSeg { get; set; }

    public int UniAudSec { get; set; }

    public int? UniAudRutFun { get; set; }

    public string? UniAudIpHost { get; set; }

    public string? UniAudConcepto { get; set; }

    public string? UniAudTipMov { get; set; }

    public string? UniAudValAnt { get; set; }

    public string? UniAudValNue { get; set; }

    public string? UniAudAtrMod { get; set; }

    public string? UniAudValKey { get; set; }

    public string? UniAudPgm { get; set; }
}
