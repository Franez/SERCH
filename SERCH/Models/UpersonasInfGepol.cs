using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasInfGepol
{
    public string UperId { get; set; } = null!;

    public short UpercorrGepol { get; set; }

    public string? UinfGepol { get; set; }

    public string? UperInfGepolVig { get; set; }

    public string? UperInfGepolPri { get; set; }

    public short? UperIngGepolDetoEnc { get; set; }

    public decimal? UperIngGepolPerr { get; set; }

    public short? UperIngGepolDetMod { get; set; }

    public DateTime? UperIngGepolFechaParte { get; set; }

    public int? UperIngGepolNroDete { get; set; }

    public short? UperIngGepolNroSecCor { get; set; }

    public string? UperIngGepolDel { get; set; }

    public string? UperIngGepolEse { get; set; }

    public string? UperIngGepolTie { get; set; }

    public string? UperIngGepolIdocore { get; set; }

    public int? UperIngGepolEinOre { get; set; }

    public short? UperIngGepolDue { get; set; }

    public string? UnifGepolCant { get; set; }
}
