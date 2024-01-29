using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class AccionEncargo
{
    public string AccEncCod { get; set; } = null!;

    public string? AccEncDes { get; set; }

    public short? AccEncVig { get; set; }
}
