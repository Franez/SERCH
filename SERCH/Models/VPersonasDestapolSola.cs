using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VPersonasDestapolSola
{
    public string UperId { get; set; } = null!;

    public string? ApePat { get; set; }

    public string? ApellMat { get; set; }

    public string? Nombre { get; set; }

    public string Documento { get; set; } = null!;

    public string? Dv { get; set; }

    public string? TipoDoc { get; set; }

    public string? Sexo { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public string? CodEstCivil { get; set; }

    public string? EstCivil { get; set; }

    public short? CodPaisNac { get; set; }

    public string? ComunaPersona { get; set; }

    public string? ProvinciaPersona { get; set; }

    public string? RegionPersona { get; set; }

    public string? Calle { get; set; }

    public string? CalleNro { get; set; }

    public string? VillaPob { get; set; }

    public string? LatitudDom { get; set; }

    public string? LongitudDom { get; set; }

    public string? NroDpto { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Profesion { get; set; }

    public string? Escolaridad { get; set; }

    public string? Email { get; set; }

    public string? CodArea { get; set; }

    public string? Telefono { get; set; }

    public string? Apodo { get; set; }
}
