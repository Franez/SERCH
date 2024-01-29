using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpReconocimientoDetalle
{
    public string InpFolio { get; set; } = null!;

    public short InpRecFolio { get; set; }

    public string InpRecPerId { get; set; } = null!;

    public short? InpRecPerPor { get; set; }
}
