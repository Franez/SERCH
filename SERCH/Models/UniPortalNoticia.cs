using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniPortalNoticia
{
    public int PncodIng { get; set; }

    public string? PntxtCor { get; set; }

    public string? PntxtCom { get; set; }

    public byte[]? PnfotNot { get; set; }

    public DateTime? PnfecIng { get; set; }

    public DateTime? PnfecHor { get; set; }

    public short? PnvigNot { get; set; }

    public string? PncargaWebs { get; set; }
}
