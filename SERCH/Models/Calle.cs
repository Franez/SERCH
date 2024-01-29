using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Calle
{
    public string CalleCod { get; set; } = null!;

    public string? CalleDes { get; set; }

    public short? CalleVigCod { get; set; }
}
