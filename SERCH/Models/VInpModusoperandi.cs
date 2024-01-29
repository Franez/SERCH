using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VInpModusoperandi
{
    public short CodFamilia { get; set; }

    public short? VigFamilia { get; set; }

    public string? Familia { get; set; }

    public short CodDetalle { get; set; }

    public string? Detalle { get; set; }

    public short? VigDetalle { get; set; }
}
