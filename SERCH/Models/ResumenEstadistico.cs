using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ResumenEstadistico
{
    public decimal EstadisId { get; set; }

    public string? EstadisJefcod { get; set; }

    public string? EstadisRegcod { get; set; }

    public string? EstadisUnicod { get; set; }

    public int? EstadisCantidad { get; set; }

    public DateTime? EstadisInpfecrecep { get; set; }

    public string? EstadisPrefcod { get; set; }

    public short? EstadisTipoordencod { get; set; }

    public short? EstadisTipdelcod { get; set; }
}
