using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class AsociacionesDoc
{
    public string UperAsoPri { get; set; } = null!;

    public string UperAsoSec { get; set; } = null!;

    public string? Asopri { get; set; }

    public string? Asosec { get; set; }
}
