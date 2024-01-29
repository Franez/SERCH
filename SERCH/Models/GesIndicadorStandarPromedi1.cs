using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesIndicadorStandarPromedi1
{
    public short GesIndCod { get; set; }

    public short GesStaIndAno { get; set; }

    public short GesStaIndNro { get; set; }

    public short? GesStaIndTipo { get; set; }

    public decimal? GesStaIndValor { get; set; }

    public decimal? GesStaIndValInf { get; set; }

    public decimal? GesStaIndValSup { get; set; }

    public short? GesStaAno1Comp { get; set; }

    public short? GesStaAno2Comp { get; set; }

    public short? GesStaMesIni1 { get; set; }

    public short? GesStaMesFin1 { get; set; }

    public short? GesStaMesIni2 { get; set; }

    public short? GesStaMesFin2 { get; set; }

    public short? GesStaIndMedicion { get; set; }

    public int? GesStaIndRutIns { get; set; }

    public int? GesStaIndRutUpd { get; set; }

    public decimal? GesStaLimite { get; set; }

    public decimal? GesStaCondZero { get; set; }

    public short? GesStaIndPreDet { get; set; }
}
