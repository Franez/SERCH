using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class FuncionariosFoto
{
    public int PerFunRut { get; set; }

    public short PerFunFotoHisNro { get; set; }

    public byte[]? PerFunFotoHisPic { get; set; }

    public string? PerFunFotoHisExt { get; set; }

    public DateTime? PerFunFotoHisFec { get; set; }

    public short? PerFunFotoHisInv { get; set; }
}
