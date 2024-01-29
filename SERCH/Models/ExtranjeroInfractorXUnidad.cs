using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ExtranjeroInfractorXUnidad
{
    public string FolioInterno { get; set; } = null!;

    public DateTime? FechaInforme { get; set; }

    public int? Mes { get; set; }

    public int? Ano { get; set; }

    public string? Unidad { get; set; }

    public string? IdPersona { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? NombreCompleto { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Pais { get; set; }

    public string? CiudadDeNacimiento { get; set; }

    public string? Sexo { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string? DigitoVerificador { get; set; }

    public string? TipoDocumento { get; set; }

    public string PaisDeEmision { get; set; } = null!;

    public string? Region { get; set; }
}
