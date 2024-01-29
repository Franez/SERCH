using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Enfermedade
{
    public short EnfCod { get; set; }

    public string? EnfDes { get; set; }

    public short? EnfTipo { get; set; }
}
