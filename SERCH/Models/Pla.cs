using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Pla
{
    public string PaisDoc { get; set; } = null!;

    public string TipoDoc { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string? NombrePersona { get; set; }

    public string? PaternoPersona { get; set; }

    public string? MaternoPersona { get; set; }

    public string Nacionalidad { get; set; } = null!;

    public DateTime? FechaPlas { get; set; }

    public DateTime? HoraPlas { get; set; }

    public string? RegPlas { get; set; }

    public string? ComunaPlas { get; set; }

    public string? CarroPlas { get; set; }

    public string? EstadoPlas { get; set; }

    public string? TipoServicioPlas { get; set; }

    public int RutFun { get; set; }

    public string? NombreFun { get; set; }

    public string? PaternoFun { get; set; }

    public string? MaternoFun { get; set; }

    public string IdPersona { get; set; } = null!;
}
