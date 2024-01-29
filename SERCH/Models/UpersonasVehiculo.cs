using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasVehiculo
{
    public string UperId { get; set; } = null!;

    public string VehPaten { get; set; } = null!;

    public short UperMarVehCod { get; set; }

    public string UperVehCod { get; set; } = null!;

    public short ColCod { get; set; }

    public string? UperVehObs { get; set; }

    public string? UperVehVig { get; set; }

    public string? UperVehPrin { get; set; }

    public string? UperVehNomCom { get; set; }
}
