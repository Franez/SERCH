using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EstadoCivil
{
    public string EstCivCod { get; set; } = null!;

    public string? EstCivDes { get; set; }

    public string? EstCivVig { get; set; }
}
