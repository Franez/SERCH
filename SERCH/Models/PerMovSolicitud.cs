using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PerMovSolicitud
{
    public int PerFunRut { get; set; }

    public short MovSolAno { get; set; }

    public short MovSolFolio { get; set; }

    public DateTime MovSolFecha { get; set; }

    public short MovSolStatus { get; set; }

    public string MovSolRegCod { get; set; } = null!;

    public string MovSolUni1 { get; set; } = null!;

    public string MovSolUni2 { get; set; } = null!;

    public string MovSolUni3 { get; set; } = null!;

    public short? MovSolMotCod { get; set; }

    public string? MovSolMotivo { get; set; }

    public short MovSolGuar { get; set; }
}
