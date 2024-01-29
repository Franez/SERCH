using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VehiculosPieza
{
    public string VehPieCod { get; set; } = null!;

    public string? VehPieDes { get; set; }

    public short? VehPieMarCod { get; set; }

    public string? VehPieNroSerie { get; set; }

    public byte[]? VehPieFoto { get; set; }

    public short? ColCod { get; set; }
}
