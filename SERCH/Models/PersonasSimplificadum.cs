using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PersonasSimplificadum
{
    public string FolioInterno { get; set; } = null!;

    public short FolioPersona { get; set; }

    public string? Nombre { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? DvDocumento { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public string? CondicionPersona { get; set; }

    public string? Naci0nalidad { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Profesion { get; set; }

    public string Sexo { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string? Etnia { get; set; }

    public string? Escolaridad { get; set; }

    public string IdPersona { get; set; } = null!;
}
