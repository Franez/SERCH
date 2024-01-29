using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesPrefecturaPolicial
{
    public string GesPrefCod { get; set; } = null!;

    public string? GesPrefDes { get; set; }

    public string? GesPrefJerCod { get; set; }

    public string? GesPrefRegion { get; set; }

    public short? GesPrefActiva { get; set; }
}
