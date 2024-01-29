using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesRegionPolicial
{
    public string GesRegPolCod { get; set; } = null!;

    public string? GesRegPolDes { get; set; }

    public short? GesRegDirDep { get; set; }

    public string? GesRegPolJer { get; set; }

    public short? GesRegPolActiva { get; set; }
}
