using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesJefaturaPolicial
{
    public string GesJefCod { get; set; } = null!;

    public string? GesJefDes { get; set; }

    public string? GesJefJerCod { get; set; }

    public short? GesJefDirDep { get; set; }

    public short? GesJefActiva { get; set; }
}
