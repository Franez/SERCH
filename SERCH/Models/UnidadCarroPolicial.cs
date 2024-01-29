using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UnidadCarroPolicial
{
    public string GesGenUniCod { get; set; } = null!;

    public string UniCarrPolId { get; set; } = null!;

    public short? UniCarrEstado { get; set; }

    public short? UniCarrVigencia { get; set; }
}
