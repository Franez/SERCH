using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PersonasAsoDestapol
{
    public string UperAsoPri { get; set; } = null!;

    public string UperAsoSec { get; set; } = null!;

    public short AsoTipCod { get; set; }

    public DateTime? UperAsoFecIni { get; set; }

    public DateTime? UperAsoFecTer { get; set; }

    public string? UperAsoUsuIns { get; set; }

    public DateTime? UperAsoFecIns { get; set; }

    public string? UperAsoWrkStIns { get; set; }

    public short? UperAsoVigencia { get; set; }

    public short? UperAsoAplIns { get; set; }

    public short? UperAsoAplUpd { get; set; }

    public string? UperAsoObs { get; set; }

    public DateTime? UperAsoFecUpd { get; set; }

    public string? UperAsoWrkStUpd { get; set; }

    public string? UperAsoUsuUpd { get; set; }

    public string? AsoTipDes { get; set; }

    public string? AsoInvDes { get; set; }
}
