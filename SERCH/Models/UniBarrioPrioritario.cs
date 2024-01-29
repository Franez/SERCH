using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniBarrioPrioritario
{
    public int UniBarrioPk { get; set; }

    public string UniBarrioNombre { get; set; } = null!;

    public string? UniBarrioRegion { get; set; }

    public int? UniBarrioCodRegion { get; set; }

    public string? UniBarrioComuna { get; set; }

    public int UniBarrioCodComuna { get; set; }
}
