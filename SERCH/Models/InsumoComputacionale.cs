using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InsumoComputacionale
{
    public string InsComCod { get; set; } = null!;

    public string? InsComDes { get; set; }

    public short? TipInsCod { get; set; }

    public string TipInsDes { get; set; } = null!;

    public short? MarComCod { get; set; }

    public string MarComDes { get; set; } = null!;

    public string? InsComModelo { get; set; }

    public string? InsComNroSerie { get; set; }

    public short? ColCod { get; set; }

    public string? InsComObs { get; set; }

    public byte[]? InsComFoto { get; set; }
}
