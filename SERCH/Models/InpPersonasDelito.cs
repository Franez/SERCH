using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpPersonasDelito
{
    public string InpFolio { get; set; } = null!;

    public int InpDelCod { get; set; }

    public string InpDelPerId { get; set; } = null!;

    public short? InpDelCond { get; set; }
}
