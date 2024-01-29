using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Telefonium
{
    public string TelCod { get; set; } = null!;

    public string? TelDes { get; set; }

    public short? MarcElecCod { get; set; }

    public string? TelNroSerie { get; set; }

    public short? TelTipo { get; set; }

    public string? TelModelo { get; set; }

    public short? ColCod { get; set; }

    public byte[]? TelFoto { get; set; }
}
