using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VHechosGeo
{
    public long? IdKey { get; set; }

    public string Inpfolio { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Unidad { get; set; }

    public DateTime? FechaDecreto { get; set; }

    public DateTime? FechaRecepcionDecreto { get; set; }

    public string DatetimeHecho { get; set; } = null!;

    public string? Resultado { get; set; }

    public string? Delito { get; set; }

    public string? AgrupacionDelito { get; set; }

    public string? RegionDiligencia { get; set; }

    public string? ComunaDiligencia { get; set; }

    public string? CalleDiligencia { get; set; }

    public string? NrodirDiligencia { get; set; }

    public string? LatDiligencia { get; set; }

    public string? LongDiligencia { get; set; }

    public string? Dni { get; set; }

    public string? Dv { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido1 { get; set; }

    public string? Apellido2 { get; set; }

    public string? Sexo { get; set; }

    public short? Edad { get; set; }

    public DateTime? FechNacimiento { get; set; }

    public string? Nacionalidad { get; set; }

    public string? CondicionImplicado { get; set; }

    public string? GrupoCriminal { get; set; }
}
