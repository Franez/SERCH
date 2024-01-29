using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniPeinRp
{
    public string Peinrpid { get; set; } = null!;

    public short PeinconCod { get; set; }

    public string? PeinconDes { get; set; }

    public string? Peinrpdoc { get; set; }

    public int? Peinrpnro { get; set; }

    public string? Peinrpsex { get; set; }

    public DateTime? PeinfecNac { get; set; }

    public string? PeintieFot { get; set; }

    public string? PeinapePat { get; set; }

    public string? PeinapeMat { get; set; }

    public string? PeinnomCom { get; set; }

    public string? PeindigVer { get; set; }

    public string? PeinpaiNac { get; set; }

    public string Peincodreg { get; set; } = null!;

    public string Peincodprov { get; set; } = null!;
}
