using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasGrupoCriminal
{
    public string GrupoCrimAsoId { get; set; } = null!;

    public int GrupoCrimCod { get; set; }

    public int GrupoCrimAsoCod { get; set; }

    public string GrupoCrimReg { get; set; } = null!;

    public string GrupoCrimProv { get; set; } = null!;

    public string GrupoCrimCom { get; set; } = null!;

    public short? GrupoCrimPos { get; set; }

    public DateTime? GrupCriAsoFecIni { get; set; }

    public DateTime? GrupCriAsoFecTer { get; set; }

    public string? GrupCriAsoUserIn { get; set; }

    public DateTime? GrupCriAsoFecIns { get; set; }

    public string? GrupCriAsoWrksIns { get; set; }

    public short? GrupCriAsoVig { get; set; }

    public short? GrupCriAsoAplIns { get; set; }

    public short? GrupCriAsoAplUdp { get; set; }

    public string? GrupCriAsoObs { get; set; }

    public DateTime? GrupCriAsoFechUpd { get; set; }

    public string? GrupCriAsoUsuUpd { get; set; }

    public string? GrupCriAsoWrkStUpd { get; set; }

    public short? GrupoCrimTipVilla { get; set; }

    public string? GrupoCrimVilla { get; set; }

    public short? GrupoAgruPrinc { get; set; }

    public decimal? GrupoPaiOpe { get; set; }

    public string? GrupoCrimCiuExt { get; set; }
}
