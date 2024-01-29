using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpPersonasVestimenta
{
    public string InpFolio { get; set; } = null!;

    public short InpPerFolio { get; set; }

    public short InpPerVestNro { get; set; }

    public short? VestCod { get; set; }

    public short? MarVestCod { get; set; }

    public string? InpPerVestObs { get; set; }

    public short? VestCorr { get; set; }
}
