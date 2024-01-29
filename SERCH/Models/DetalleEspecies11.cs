using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DetalleEspecies11
{
    public string? Decreto { get; set; }

    public string? TipoEspecie { get; set; }

    public string? Descripcion { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public decimal? Cantidad { get; set; }

    public string FolioInterno { get; set; } = null!;

    public decimal? Valor { get; set; }

    public long? Total { get; set; }

    public string? EstadoEspecie { get; set; }
}
