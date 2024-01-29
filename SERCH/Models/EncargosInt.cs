using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EncargosInt
{
    public string IntTipEncCod { get; set; } = null!;

    public string? IntTipEncDes { get; set; }

    public short? IntTipEncVig { get; set; }
}
