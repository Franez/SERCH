using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesMetasDetalle
{
    public short MetasCod { get; set; }

    public short GesIndCod { get; set; }

    public decimal? MetasGesIndPor { get; set; }

    public decimal? MetasGesIndVal { get; set; }

    public short? GesIndActivo { get; set; }

    public short? MetasGesFlgInf { get; set; }
}
