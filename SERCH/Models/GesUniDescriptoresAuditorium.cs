using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniDescriptoresAuditorium
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public int GesMedCod { get; set; }

    public DateTime GesMedFchUni { get; set; }

    public int GesMedFchCorr { get; set; }

    public int? GesMedFchAudRut { get; set; }

    public decimal? GesMedFchAudVal { get; set; }

    public DateTime? GesMedFchAudDate { get; set; }

    public string? GesMedFchAudIp { get; set; }
}
