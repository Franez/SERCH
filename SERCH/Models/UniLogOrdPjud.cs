using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniLogOrdPjud
{
    public decimal FolPjud { get; set; }

    public string? PjudSdtIn { get; set; }

    public string? PjudSdtOut { get; set; }

    public DateTime? PjudFchHra { get; set; }

    public string? FolPjudWs { get; set; }
}
