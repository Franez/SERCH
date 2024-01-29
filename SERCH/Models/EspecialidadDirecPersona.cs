using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EspecialidadDirecPersona
{
    public string NumeroDocumento { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Sexo { get; set; }

    public string Genero { get; set; } = null!;

    public string? Etnia { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? EspecialidadDelictual { get; set; }

    public string? Region { get; set; }

    public string? Comuna { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public string IdPersona { get; set; } = null!;
}
