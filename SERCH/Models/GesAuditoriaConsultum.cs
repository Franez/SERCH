using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesAuditoriaConsultum
{
    public int GesAudiFunRut { get; set; }

    public decimal GesAudiConCorr { get; set; }

    public string? GesAudiConIp { get; set; }

    public DateTime? GesAudiConFecha { get; set; }

    public DateTime? GesAudiConFecCon { get; set; }

    public string? GesAudiConUniCod { get; set; }

    public string? GesAudiConUniObj { get; set; }

    public string? GesAudiConTipo { get; set; }

    public decimal GesAudiConInvCorr { get; set; }
}
