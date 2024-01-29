using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VLock
{
    public int Sessionid { get; set; }

    public string Type { get; set; } = null!;

    public int Dbid { get; set; }

    public string? Objectname { get; set; }

    public string Rmode { get; set; } = null!;

    public string Rstatus { get; set; } = null!;
}
