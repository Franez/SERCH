using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAbrirDocumento
{
    public string InpFolio { get; set; } = null!;

    public short InpEndNro { get; set; }

    public short UniAbrNro { get; set; }

    public DateTime? UniAbrFec { get; set; }

    public DateTime? UniAbrHor { get; set; }

    public int? UniAbrRfa { get; set; }

    public string? UniAbrObs { get; set; }
}
