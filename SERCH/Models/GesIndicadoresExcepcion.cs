using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesIndicadoresExcepcion
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesExcepIndCod { get; set; }

    public short GesExcepIndAno { get; set; }

    public short GesExcepMesUno { get; set; }

    public short GesExcepMesDos { get; set; }

    public decimal? GesExcepValor { get; set; }

    public int? GesExcepFunIns { get; set; }

    public int? GesExcepFunUpd { get; set; }

    public DateTime? GesExcepFecIns { get; set; }

    public DateTime? GesExcepFecUpd { get; set; }
}
