using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UnidadMedidum
{
    public string MedUniCod { get; set; } = null!;

    public string MedUniDes { get; set; } = null!;

    public short? MedUniDroga { get; set; }
}
