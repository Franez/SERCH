using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniPgmParametro
{
    public short ApliFunPerfil { get; set; }

    public short UniCodMenu { get; set; }

    public short UniNroLinPar { get; set; }

    public string UniPgmPar { get; set; } = null!;
}
