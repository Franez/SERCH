using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniCalle
{
    public string Nombrevial { get; set; } = null!;

    public short Tipocalle { get; set; }

    public short Nroregion { get; set; }

    public string Comizq { get; set; } = null!;

    public string Comider { get; set; } = null!;

    public string Region { get; set; } = null!;

    public string Desctipocalle { get; set; } = null!;
}
