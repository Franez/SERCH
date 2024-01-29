using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniDescriptore
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public int GesMedCod { get; set; }

    public short? GesUniValTipo { get; set; }

    public short? GesUniDesUnidad { get; set; }

    public decimal? GesUniValMed { get; set; }

    public int? GesFunRutIns { get; set; }

    public int? GesFunRutUpd { get; set; }

    public DateTime? GesFunHrsModDatos { get; set; }

    public short? GesUniDesIngManual { get; set; }

    public short? GesUniDesClase { get; set; }

    public short? GesUniDesProceso { get; set; }
}
