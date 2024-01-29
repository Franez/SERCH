using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VDestapolDatosPersonalesBrain
{
    public string UperId { get; set; } = null!;

    public string? ApePat { get; set; }

    public string? ApellMat { get; set; }

    public string? Nombre { get; set; }

    public string Documento { get; set; } = null!;

    public string? Dv { get; set; }

    public string? TipoDoc { get; set; }

    public string? Sexo { get; set; }

    public string Genero { get; set; } = null!;

    public string? Etnia { get; set; }

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

    public string? Nacionalidad { get; set; }

    public string? Profesion { get; set; }

    public string? Escolaridad { get; set; }

    public string TipoInmueble { get; set; } = null!;

    public string? NroInmueble { get; set; }

    public short? UperTipBcd { get; set; }

    public string? LatitudDomicilio { get; set; }

    public string? LongitudDomicilio { get; set; }

    public string? EstudiosTerminados { get; set; }
}
