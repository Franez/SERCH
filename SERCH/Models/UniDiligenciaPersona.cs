using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniDiligenciaPersona
{
    public string InpFolio { get; set; } = null!;

    public short InpPerFolio { get; set; }

    public short UniDilCod { get; set; }

    public DateTime? UniDilFec { get; set; }

    public DateTime? UniDilHor { get; set; }

    public string? UniDilDil { get; set; }

    public string? UniDilRel { get; set; }

    public string? UniDiliMot { get; set; }

    public string? UniDiliObs { get; set; }
}
