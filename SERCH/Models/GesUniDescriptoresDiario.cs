using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniDescriptoresDiario
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public int GesMedCod { get; set; }

    public DateTime GesMedFchUni { get; set; }

    public decimal? GesMedFchVal { get; set; }

    public int? GesMedFchRutIns { get; set; }

    public int? GesMedFchRutUpd { get; set; }

    public DateTime? GesMedFchDateIns { get; set; }

    public DateTime? GesMedFchDateUpd { get; set; }
}
