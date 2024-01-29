using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class SsOfan
{
    public string FolioInterno { get; set; } = null!;

    public short NSs { get; set; }

    public string? Comuna { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public string? Lugar { get; set; }

    public string? Detalle { get; set; }
}
