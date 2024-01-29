using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Antiguedade
{
    public string AntObjCod { get; set; } = null!;

    public string? AntObjDes { get; set; }

    public short? TipAntiCod { get; set; }

    public short? AntColCod { get; set; }

    public short? AntObjAno { get; set; }

    public short? AntObjPaiOri { get; set; }

    public string? AntObjAutor { get; set; }

    public string? AntObjObs { get; set; }

    public byte[]? AntObjFoto { get; set; }
}
