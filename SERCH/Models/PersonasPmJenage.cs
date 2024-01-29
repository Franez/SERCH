using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PersonasPmJenage
{
    public string? RegionUnidad { get; set; }

    public string? Unidad { get; set; }

    public string? Jefatura { get; set; }

    public string? Prefectura { get; set; }

    public string? Decreto { get; set; }

    public string? Condicion { get; set; }

    public string? Delito { get; set; }

    public string FolioInterno { get; set; } = null!;

    public string? NumeroDocumentoPersona { get; set; }

    public DateTime? FechaDetencion { get; set; }

    public string? HoraMinutoDetencion { get; set; }

    public string? OrganismoGuber { get; set; }

    public string? DetalleOrganisgoGuber { get; set; }

    public string? Nacionalidad { get; set; }

    public string EstadoDetencion { get; set; } = null!;
}
