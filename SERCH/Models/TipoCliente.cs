using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoCliente
{
    public short TipoClienteId { get; set; }

    public string TipoClienteDescripcion { get; set; } = null!;
}
