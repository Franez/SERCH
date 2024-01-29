using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniInfxDec
{
    public string InpFolio { get; set; } = null!;

    public short InpCodInfExt { get; set; }

    public int? InpCodDelInfExt { get; set; }
}
