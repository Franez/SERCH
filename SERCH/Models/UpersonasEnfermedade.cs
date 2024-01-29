using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasEnfermedade
{
    public string UperId { get; set; } = null!;

    public short EnfCod { get; set; }

    public string? EnfVig { get; set; }
}
