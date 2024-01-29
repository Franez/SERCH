using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniOtrosDocumento
{
    public string InpFolio { get; set; } = null!;

    public short UniOtDnro { get; set; }

    public string? UniOtDdes { get; set; }

    public short? UniUltLinDoc { get; set; }
}
