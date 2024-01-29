using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniInstFiscal
{
    public string InpFolio { get; set; } = null!;

    public short UniInstCor { get; set; }

    public DateTime? UniInstFec { get; set; }

    public DateTime? UniInstHor { get; set; }

    public string? UniInstIns { get; set; }

    public string? UniInstIdf { get; set; }

    public int? UniInstFis { get; set; }

    public short? UniInstFfi { get; set; }

    public short? UniInstMed { get; set; }

    public string? UniConFis { get; set; }

    public string? UniInsFol { get; set; }
}
