using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class BasePersona
{
    public string Id { get; set; } = null!;

    public string NumDoc { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? _1Apellido { get; set; }

    public string? _2Apellido { get; set; }

    public string Sexo { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string? Etnia { get; set; }

    public DateTime? FechaNac { get; set; }

    public string Nacional { get; set; } = null!;
}
