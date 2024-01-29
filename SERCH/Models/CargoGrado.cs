using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class CargoGrado
{
    public short CargoCod { get; set; }

    public short CarGraCod { get; set; }

    public string CarGraDes { get; set; } = null!;
}
