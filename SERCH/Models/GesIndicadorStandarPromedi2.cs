using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesIndicadorStandarPromedi2
{
    public short GesIndCod { get; set; }

    public short GesStaIndAno { get; set; }

    public short GesStaIndNro { get; set; }

    public short GesStaProNro { get; set; }

    public short? GesStaProAno { get; set; }

    public short? GesStaProMesIni { get; set; }

    public short? GesStaProMesFin { get; set; }
}
