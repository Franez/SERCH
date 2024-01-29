using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasEstablecimiento
{
    public string Uperid { get; set; } = null!;

    public decimal Upersinestnro { get; set; }

    public decimal? Upersinestrut { get; set; }

    public decimal? Upersinestsuc { get; set; }

    public string? Upersinestrol { get; set; }

    public DateTime? Upersinestfec { get; set; }

    public string? Upersinestusu { get; set; }

    public string? Upersinestwrk { get; set; }
}
