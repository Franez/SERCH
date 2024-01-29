using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VDeteFoto
{
    public string Uperid { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string? Dv { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string? NombreCompleto { get; set; }

    public string? UperCondDes { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public DateTime? UperFchNac { get; set; }

    public decimal? Edad { get; set; }

    public string Nacionalidad { get; set; } = null!;

    public string Escolaridad { get; set; } = null!;
}
