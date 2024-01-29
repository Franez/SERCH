using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniTipoResidencium
{
    public short UniTpResidenciaCod { get; set; }

    public string UniTpResidenciaDes { get; set; } = null!;

    public short UniTpResidenciaVig { get; set; }
}
