using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniDelConclu
{
    public string InpFolio { get; set; } = null!;

    public short InpClcFolio { get; set; }

    public int InpClcDelCod { get; set; }
}
