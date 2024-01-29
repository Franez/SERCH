using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpNumeradorDocumento
{
    public string GesGenUniCod { get; set; } = null!;

    public short InpNumAnio { get; set; }

    public int? InpNumFolio { get; set; }
}
