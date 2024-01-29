using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ResumenEstadisticoDroga
{
    public decimal EstadisdrogaId { get; set; }

    public short EstadisdrogaDrogcod { get; set; }

    public string EstadisdrogaJefcod { get; set; } = null!;

    public int EstadisdrogaCantidad { get; set; }

    public string EstadisdrogaPrefcod { get; set; } = null!;

    public short EstadisdrogaTipoordencod { get; set; }

    public string EstadisdrogaRegcod { get; set; } = null!;

    public string EstadisdrogaUnicod { get; set; } = null!;

    public DateTime EstadisdrogaInpfecrecep { get; set; }
}
