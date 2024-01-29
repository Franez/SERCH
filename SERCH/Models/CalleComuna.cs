using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class CalleComuna
{
    public string ComCod { get; set; } = null!;

    public string CalleCod { get; set; } = null!;

    public short TipCalleCod { get; set; }

    public short? ComCalleVig { get; set; }

    public string? ComCalleConCat { get; set; }
}
