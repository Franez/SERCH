using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Joya
{
    public string JoyCod { get; set; } = null!;

    public string? JoyDes { get; set; }

    public short? JoyMatCod { get; set; }

    public string JoyMatDes { get; set; } = null!;

    public short? JoyFamCod { get; set; }

    public string JoyFamDes { get; set; } = null!;

    public short? JoyForCod { get; set; }

    public string JoyForDes { get; set; } = null!;

    public short? JoyMaePieCod { get; set; }

    public decimal? JoyPeso { get; set; }

    public string? JoyObs { get; set; }

    public byte[]? JoyFoto { get; set; }

    public short? JoyVig { get; set; }
}
