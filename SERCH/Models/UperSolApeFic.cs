using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperSolApeFic
{
    public string UperId { get; set; } = null!;

    public short UperFolSol { get; set; }

    public string? UperMotApe { get; set; }

    public int? UperFunsol { get; set; }

    public DateTime? UperFchSol { get; set; }

    public int? UperFunCie { get; set; }

    public DateTime? UperFchCie { get; set; }
}
