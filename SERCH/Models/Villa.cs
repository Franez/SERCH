using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Villa
{
    public string VilCod { get; set; } = null!;

    public string? VilDes { get; set; }

    public short? VillaPoblaCod { get; set; }

    public string? VilComCod { get; set; }

    public short VillaVig { get; set; }
}
