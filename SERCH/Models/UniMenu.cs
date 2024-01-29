using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniMenu
{
    public short ApliFunPerfil { get; set; }

    public short UniCodMenu { get; set; }

    public string UniPgmMenu { get; set; } = null!;

    public string UniNomMenu { get; set; } = null!;

    public short UniCodSubMenu { get; set; }

    public string UniVigMenu { get; set; } = null!;

    public short UniUltLinPar { get; set; }
}
