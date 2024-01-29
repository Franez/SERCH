using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniIndicadore
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public short GesUniIndCod { get; set; }

    public decimal? GesUniIndValor { get; set; }

    public int? GesUniIndRutIns { get; set; }

    public int? GesUniIndRutUpd { get; set; }

    public decimal? GesUniIndStaInf { get; set; }

    public decimal? GesUniIndStaSup { get; set; }

    public decimal? GesUniIndStaValor { get; set; }

    public short? GesUniIndStaMed { get; set; }

    public short? GesUniIndAprTipo { get; set; }

    public DateTime? GesUniIndFchIndIns { get; set; }

    public DateTime? GesUniIndFchHoraIns { get; set; }

    public short? GesUniIndIngManual { get; set; }

    public short? GesUniIndClase { get; set; }

    public short? GesUniIndAnoComp { get; set; }

    public short? GesUniIndMesComp { get; set; }

    public decimal? GesUniIndValComp { get; set; }

    public decimal? GesUniIndPorPerAnt { get; set; }

    public string? GesUniIndPerResultado { get; set; }

    public short? GesUniIndProceso { get; set; }
}
