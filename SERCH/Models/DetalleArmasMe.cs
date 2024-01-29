using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DetalleArmasMe
{
    public string? Decreto { get; set; }

    public string? TipoArma { get; set; }

    public string? Detalle { get; set; }

    public string FolioInterno { get; set; } = null!;
}
