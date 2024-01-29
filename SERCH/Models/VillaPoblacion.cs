using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VillaPoblacion
{
    public string ComCod { get; set; } = null!;

    public string VilCod { get; set; } = null!;

    public short? VilComVig { get; set; }
}
