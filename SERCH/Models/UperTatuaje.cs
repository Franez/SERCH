using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperTatuaje
{
    public string UperId { get; set; } = null!;

    public short UperTatNro { get; set; }

    public short TipTatuCod { get; set; }

    public short FisUbiCod { get; set; }

    public string? UperTatImgExt { get; set; }

    public string? UpertatImgNom { get; set; }

    public byte[]? UperTatImg { get; set; }
}
