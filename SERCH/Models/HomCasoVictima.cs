using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoVictima
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short HomVicNro { get; set; }

    public short? HomVicRec { get; set; }

    public string? HomVicDataHom { get; set; }

    public string? HomVicId { get; set; }

    public DateTime? HomVicFecDef { get; set; }

    public string? HomVicNn { get; set; }

    public string? HomVicIdenPor { get; set; }

    public short? HomVicMedTip { get; set; }

    public string? HomVicMedInf { get; set; }

    public string? HomVicCausa { get; set; }

    public string? HomVicObs { get; set; }

    public string? HomVicUbi { get; set; }

    public string? HomVicAntPol { get; set; }

    public short? HomModCod { get; set; }

    public short? HomMovTipCod { get; set; }
}
