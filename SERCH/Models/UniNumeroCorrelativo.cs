using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniNumeroCorrelativo
{
    public string UninroCorrUni { get; set; } = null!;

    public short UninroCorrAno { get; set; }

    public decimal UninroCorrNro { get; set; }

    public string UninroCorrLet { get; set; } = null!;

    public string UniNroCorrFol { get; set; } = null!;
}
