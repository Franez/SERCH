using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InfractoresBrain
{
    public string FolioInterno { get; set; } = null!;

    public string? TipoDecreto { get; set; }

    public string? Unidad { get; set; }

    public string? Infraccion { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public DateTime? FechaInforme { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Nombre { get; set; }

    public string? _1Apellido { get; set; }

    public string? _2Apellido { get; set; }

    public string? Nacionalidad { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string IdPer { get; set; } = null!;
}
