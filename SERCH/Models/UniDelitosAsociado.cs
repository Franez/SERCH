using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniDelitosAsociado
{
    public string InpFolio { get; set; } = null!;

    public short UniDasnro { get; set; }

    public int? Unidasdel { get; set; }

    public string? UniDasobs { get; set; }
}
