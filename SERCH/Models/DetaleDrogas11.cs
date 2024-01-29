using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DetaleDrogas11
{
    public string? DecReto { get; set; }

    public string? TipoDroga { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public decimal? Cantidad { get; set; }

    public string FolioInterno { get; set; } = null!;
}
