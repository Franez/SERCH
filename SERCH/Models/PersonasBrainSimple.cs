using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PersonasBrainSimple
{
    public string FolioInterno { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Unidad { get; set; }

    public string? RegionUnidad { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public string? Delito { get; set; }

    public string? ComunaHecho { get; set; }

    public string? Ruc { get; set; }

    public string? Organismo { get; set; }

    public string? DetOrganismo { get; set; }

    public string? Condicion { get; set; }

    public string NumDoc { get; set; } = null!;

    public string? Dv { get; set; }

    public string Nacionalidad { get; set; } = null!;

    public string? Nomrbe { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public string? Sexo { get; set; }

    public string Genero { get; set; } = null!;

    public string? Etnia { get; set; }

    public string EstadoDecreto { get; set; } = null!;

    public string IdPersona { get; set; } = null!;

    public DateTime? FechaDetencion { get; set; }

    public short HoraDetencion { get; set; }

    public string? EstadoDetenido { get; set; }

    public string? CondicionFallecido { get; set; }

    public string? ComunaDetencion { get; set; }
}
