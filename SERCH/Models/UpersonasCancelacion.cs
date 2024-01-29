using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasCancelacion
{
    public string UperId { get; set; } = null!;

    public short UperCanAntNro { get; set; }

    public short? UperCanStatus { get; set; }

    public DateTime? UperCanAntFec { get; set; }

    public short? UperCanAntTipo { get; set; }

    public string? UperCanFun { get; set; }

    public string? UperCanUni { get; set; }

    public string? UperCanResolex { get; set; }

    public string? UperCanNroDoc { get; set; }

    public DateTime? UperCanFecDoc { get; set; }

    public short? UperCanNiv { get; set; }

    public short? UperCanRevNiv { get; set; }

    public string? UperCanRevObs { get; set; }

    public string? UperCanUniEmiDoc { get; set; }

    public int? UperCanFunEmiDoc { get; set; }

    public DateTime? UperCanInsFec { get; set; }

    public string? UperCanInsWrk { get; set; }

    public string? UperCanObs { get; set; }

    public short? OrgCod { get; set; }

    public int? OrgDetNro { get; set; }

    public string? EncTipDocCod { get; set; }

    public string? UperCanFunUpd { get; set; }

    public string? UperCanUniUpd { get; set; }

    public DateTime? UperCanUpdFec { get; set; }

    public string? UperCanUpdWrk { get; set; }
}
