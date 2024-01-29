using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Ciudade
{
    public short Ciucod { get; set; }

    public string Ciunom { get; set; } = null!;

    public string CiuProvCod { get; set; } = null!;

    public string Regcod { get; set; } = null!;
}
