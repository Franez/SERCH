using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperAuditoria
{
    public decimal UperAudFolio { get; set; }

    public DateTime? UperAudFecHora { get; set; }

    public string? UperAudFun { get; set; }

    public string? UperAudTipo { get; set; }

    public string? UperAudIp { get; set; }

    public string? UperAudUni { get; set; }

    public string? UperAudNomConcat { get; set; }

    public string? UperAudPerId { get; set; }

    public decimal UperAudInvCorr { get; set; }

    public string? UperAudObs { get; set; }
}
