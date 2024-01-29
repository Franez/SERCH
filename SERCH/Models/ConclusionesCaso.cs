using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ConclusionesCaso
{
    public string Folio { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Conclusion { get; set; }

    public string? Relato { get; set; }

    public string? Delito { get; set; }

    public string? CondicionPersona { get; set; }

    public string? NumDoc { get; set; }

    public string? Nombre { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public DateTime? FechaInforme { get; set; }

    public string? Unidad { get; set; }
}
