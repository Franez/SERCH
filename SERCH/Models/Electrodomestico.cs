using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Electrodomestico
{
    public string ElecCod { get; set; } = null!;

    public string? ElecDes { get; set; }

    public short? TipElecCod { get; set; }

    public string TipElecDes { get; set; } = null!;

    public short? MarcElecCod { get; set; }

    public short? ColCod { get; set; }

    public string? ElecModelo { get; set; }

    public short? ElecFamCod { get; set; }

    public byte[]? ElecFoto { get; set; }
}
