using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperCicatrice
{
    public string UperId { get; set; } = null!;

    public short UperCicNro { get; set; }

    public short? TipCicaCod { get; set; }

    public short? FisUbiCod { get; set; }

    public short? UperCicTipo { get; set; }

    public byte[]? UperCicImg { get; set; }

    public string? UperCicExtImg { get; set; }

    public string? UperCicNomImg { get; set; }
}
