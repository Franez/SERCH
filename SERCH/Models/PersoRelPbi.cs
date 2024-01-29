using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PersoRelPbi
{
    public string FolioInterno { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Condicion { get; set; }

    public string? ComunaHecho { get; set; }

    public DateTime? FechaInforme { get; set; }

    public string? IdPersona { get; set; }

    public string? DelitoDecreto { get; set; }
}
