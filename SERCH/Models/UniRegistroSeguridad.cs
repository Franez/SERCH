using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniRegistroSeguridad
{
    public string InpFolio { get; set; } = null!;

    public short RsnroCorr { get; set; }

    public short? RsregVig { get; set; }

    public int? RsrutFun { get; set; }

    public short? RsnivSeg { get; set; }

    public DateTime? RsfecSeg { get; set; }

    public string? RshorSeg { get; set; }

    public string? RsobsSeg { get; set; }

    public DateTime? RsfinSeg { get; set; }

    public string? RscodUni { get; set; }

    public int? RsfunDoc { get; set; }
}
