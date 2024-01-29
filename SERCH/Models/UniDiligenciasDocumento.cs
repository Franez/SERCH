using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniDiligenciasDocumento
{
    public string InpFolio { get; set; } = null!;

    public short InpDilNro { get; set; }

    public short InpCorrDilDoc { get; set; }

    public string? InpDscDocDil { get; set; }
}
