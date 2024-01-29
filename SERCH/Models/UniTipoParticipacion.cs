using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniTipoParticipacion
{
    public decimal Unitippartcod { get; set; }

    public string Unitippartdesc { get; set; } = null!;

    public decimal Unitippartvig { get; set; }
}
