using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ApodosDestapol
{
    public string? NumeroDocumento { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? Sexo { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Apodo { get; set; }

    public string? Reg { get; set; }

    public string? Comuna { get; set; }

    public string? Calle { get; set; }

    public string? Nro { get; set; }

    public string? Dpto { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }
}
