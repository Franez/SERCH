using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class AsociacionesPersona
{
    public string IdPersona { get; set; } = null!;

    public string Run1 { get; set; } = null!;

    public string? Dv1 { get; set; }

    public string? Nombre { get; set; }

    public string? _1Apellido { get; set; }

    public string? _2Apellido { get; set; }

    public DateTime? FechaNac { get; set; }

    public string Nacionalidad { get; set; } = null!;

    public string? Asociacion { get; set; }

    public string? Completo1 { get; set; }

    public string IdPersonaAso { get; set; } = null!;

    public string Run2 { get; set; } = null!;

    public string? Dv2 { get; set; }

    public string? NombreAso { get; set; }

    public string? _1ApellidoAso { get; set; }

    public string? _2ApellidoAso { get; set; }

    public DateTime? FechaNacAso { get; set; }

    public string NacionalidadAso { get; set; } = null!;

    public string? AsociacionInv { get; set; }

    public string? Completo2 { get; set; }

    public string? FotoPerso1 { get; set; }

    public string? FotoPerso2 { get; set; }
}
