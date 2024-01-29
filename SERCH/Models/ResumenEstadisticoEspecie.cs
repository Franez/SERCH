using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ResumenEstadisticoEspecie
{
    public decimal EstadisespecieId { get; set; }

    public string EstadisespecieRegcod { get; set; } = null!;

    public string EstadisespecieJefcod { get; set; } = null!;

    public int EstadisespecieCantidad { get; set; }

    public DateTime EstadisespecieInpfecrecep { get; set; }

    public string EstadisespeciePrefcod { get; set; } = null!;

    public short EstadisespecieInpesptipo { get; set; }

    public short EstadisespecieTipoordencod { get; set; }

    public string EstadisespecieUnicod { get; set; } = null!;
}
