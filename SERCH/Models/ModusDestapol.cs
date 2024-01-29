using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ModusDestapol
{
    public string FolioInternoDecreto { get; set; } = null!;

    public short? CodFormContacto { get; set; }

    public string? FormaDeContacto { get; set; }

    public short? CodCantImputados { get; set; }

    public string? CantidadImputados { get; set; }

    public short? CodGenero { get; set; }

    public string? Genero { get; set; }

    public short? CodRangoEtario { get; set; }

    public string? RangoEtario { get; set; }

    public short? CodPuntoAcceso { get; set; }

    public string? PuntoAcceso { get; set; }

    public short? CodMedHerramientas { get; set; }

    public string? MediosOHerramientas { get; set; }

    public short? CodTransporte { get; set; }

    public string? TransporteUsado { get; set; }

    public short? CodModalidad { get; set; }

    public string? Modalidad { get; set; }

    public string? SelloPersonal { get; set; }

    public string? AccionesPrevias { get; set; }
}
