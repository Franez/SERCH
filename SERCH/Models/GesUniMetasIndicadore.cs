using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniMetasIndicadore
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public short MetasCod { get; set; }

    public short GesIndCod { get; set; }

    public short? GesIndStanMed { get; set; }

    public decimal? GesIndRanStaInf { get; set; }

    public decimal? GesIndRanStaSup { get; set; }

    public decimal? GesIndStanVal { get; set; }

    public decimal? GesIndNota { get; set; }

    public decimal? GesIndMetaPond { get; set; }

    public decimal? GesUniValInd { get; set; }

    public decimal? GesUniValPerComp { get; set; }

    public decimal? GesUniPorRes { get; set; }

    public short? GesIndAnoComp { get; set; }

    public short? GesIndMesComp { get; set; }

    public short? GesIndMetodo { get; set; }

    public string? GesUniIndResultado { get; set; }

    public int? GesUniIndFunIns { get; set; }

    public DateTime? GesUniIndFecIns { get; set; }

    public int? GesUniIndFunValIns { get; set; }

    public DateTime? GesUniIndFecValIns { get; set; }

    public short? GesUniIndMetaProceso { get; set; }
}
