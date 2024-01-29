using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoDocumento
{
    public string TipDocCod { get; set; } = null!;

    public string TipDocDes { get; set; } = null!;

    public string TipDocDve { get; set; } = null!;

    public short? TipDocMinCod { get; set; }

    public short? TipDocSinNumDoc { get; set; }
}
