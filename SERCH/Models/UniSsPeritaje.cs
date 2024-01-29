using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniSsPeritaje
{
    public string InpFolio { get; set; } = null!;

    public short InpSsfolio { get; set; }

    public short UniPeriCod { get; set; }

    public string Inpunicodperitaje { get; set; } = null!;

    public short InpSucfolio { get; set; }

    public short? UniIdJefPer { get; set; }

    public short? UniIdUniPer { get; set; }

    public string? Inpssnue { get; set; }

    public string? UniPeriTipoOtro { get; set; }
}
