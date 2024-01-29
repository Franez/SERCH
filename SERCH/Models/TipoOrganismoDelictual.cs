using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoOrganismoDelictual
{
    public short Tiporgcrimcod { get; set; }

    public string Tiporgcrimdsc { get; set; } = null!;

    public short Tiporgcrimvig { get; set; }
}
