using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InstrumentosMusicale
{
    public string MusInscod { get; set; } = null!;

    public string? MusInsDes { get; set; }

    public short? TipMusCod { get; set; }

    public string TipMusDes { get; set; } = null!;

    public short? MatTipCod { get; set; }

    public string MatTipDes { get; set; } = null!;

    public short? FamInsCod { get; set; }

    public string FamInsDes { get; set; } = null!;

    public short? MusMarCod { get; set; }

    public string MusMarDes { get; set; } = null!;

    public string? MusInsModelo { get; set; }

    public byte[]? MusInsFoto { get; set; }
}
