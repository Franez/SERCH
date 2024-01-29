using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class RedesSocialesPersona
{
    public string NumDoc { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? _1Apellido { get; set; }

    public string? _2Apellido { get; set; }

    public string? Sexo { get; set; }

    public string Genero { get; set; } = null!;

    public string? Etnia { get; set; }

    public DateTime? FechaNac { get; set; }

    public int? Edad { get; set; }

    public string? TipoRedSoc { get; set; }

    public string? UsarioNick { get; set; }

    public string? Url { get; set; }

    public string? OtraRedSocial { get; set; }

    public string IdPersona { get; set; } = null!;
}
