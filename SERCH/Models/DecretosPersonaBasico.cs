using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosPersonaBasico
{
    public string? GrupoContexto { get; set; }

    public string? DetalleContexto { get; set; }

    public string FolioInterno { get; set; } = null!;

    public string? TipoOrden { get; set; }

    public string? Delito { get; set; }

    public string? Unidad { get; set; }

    public string? Condicion { get; set; }

    public DateTime? FechaDetencion { get; set; }

    public short HoraDetencion { get; set; }

    public string? ComunaDetencion { get; set; }

    public string? MotivoDetencion { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Sexo { get; set; }

    public string Genero { get; set; } = null!;

    public string? Etnia { get; set; }

    public string? NumDocumento { get; set; }

    public string? Nombre { get; set; }

    public string? _1Apellido { get; set; }

    public string? _2Apellido { get; set; }

    public int? Edad { get; set; }

    public string IdPersona { get; set; } = null!;
}
