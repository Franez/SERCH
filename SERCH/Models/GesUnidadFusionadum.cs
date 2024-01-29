using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUnidadFusionadum
{
    public string GesFusUniId { get; set; } = null!;

    public short GesFusUniNro { get; set; }

    public string? GesFusUnidad { get; set; }

    public DateTime? GesFusFec { get; set; }

    public short? GesFusUniActiva { get; set; }
}
