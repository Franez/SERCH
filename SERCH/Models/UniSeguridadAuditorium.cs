using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniSeguridadAuditorium
{
    public int SarutFun { get; set; }

    public string SaperId { get; set; } = null!;

    public DateTime SafecCon { get; set; }

    public string SahorCon { get; set; } = null!;

    public DateTime? SafecHor { get; set; }

    public short? SaestLec { get; set; }
}
