using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUnidadDepartamento
{
    public string GesUniDepCod { get; set; } = null!;

    public string? GesUniDepDes { get; set; }

    public string? GesUniDepReg { get; set; }

    public short? GesUniDepEsp { get; set; }

    public short? GesUniDepDir { get; set; }

    public string? GesUniDepPref { get; set; }

    public string? GesUniDepJef { get; set; }

    public string? GesUniDepJerCod { get; set; }

    public short? GesUniDepActiva { get; set; }
}
