using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Vehiculo
{
    public string VehCod { get; set; } = null!;

    public string? VehDes { get; set; }

    public short? MarVehCod { get; set; }

    public short? VehAno { get; set; }

    public short? VehColCod { get; set; }

    public string? VehMarModelo { get; set; }

    public short? TvhCod { get; set; }

    public byte[]? VehFoto { get; set; }

    public int VehcodN { get; set; }
}
