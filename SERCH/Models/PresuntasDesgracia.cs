using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PresuntasDesgracia
{
    public string FolioInterno { get; set; } = null!;

    public string? Decreto { get; set; }

    public DateTime? FechaDoc { get; set; }

    public string? Organismo { get; set; }

    public string? DetalleOrganismo { get; set; }

    public string Evaluacion { get; set; } = null!;

    public string? Delito { get; set; }

    public string? Unidad { get; set; }

    public string? ConRSinR { get; set; }

    public DateTime? FechaInforme { get; set; }

    public short NumImpli { get; set; }

    public string? CodPersona { get; set; }

    public string? Nombre { get; set; }

    public string? _1Apellido { get; set; }

    public string? _2Apellido { get; set; }

    public DateTime? FecNac { get; set; }

    public string? Sexo { get; set; }

    public int? Edad { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Tag { get; set; }
}
