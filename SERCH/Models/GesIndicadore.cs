using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesIndicadore
{
    public short GesIndCod { get; set; }

    public string? GesIndDes { get; set; }

    public short? GesMedSta { get; set; }

    public decimal? GesValSta1 { get; set; }

    public decimal? GesValSta2 { get; set; }

    public short? GesIndTipo { get; set; }

    public short? GesIndCalc { get; set; }

    public decimal? GesIndPond { get; set; }

    public string? GesIndTxtExpl { get; set; }

    public short? GesIndSistema { get; set; }

    public short? GesIndExcep { get; set; }

    public short? GesIndExcMed { get; set; }

    public short? GesIndNivAcum { get; set; }

    public short? GesIndRmtodas { get; set; }

    public short? GesIndValido { get; set; }

    public short? GesIndCavas { get; set; }
}
