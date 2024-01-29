using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniContadorVisita
{
    public decimal IdVisita { get; set; }

    public int? PerfunRutVisita { get; set; }

    public DateTime? PerFunDateVisita { get; set; }

    public short? PerMes { get; set; }

    public short? PerAnio { get; set; }

    public string? PerFunUnidad { get; set; }

    public string? PerWrkIns { get; set; }
}
