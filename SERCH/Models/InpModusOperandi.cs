using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpModusOperandi
{
    public string InpFolio { get; set; } = null!;

    public short InpModFolio { get; set; }

    public short? ModOpCod { get; set; }

    public short? ModOpDetCod { get; set; }

    public string? InpModObs { get; set; }

    public short? InpModCantSuj { get; set; }

    public short? InpModRolGen { get; set; }

    public short? InpModForCon { get; set; }

    public short? InpModMedHer { get; set; }

    public short? InpModAbordo { get; set; }

    public short? InpModAlias { get; set; }

    public short? InpModTrans { get; set; }

    public short? InpModRanEta { get; set; }

    public short? InpModPntAcc { get; set; }

    public string? InpModOpeMarPer { get; set; }
}
