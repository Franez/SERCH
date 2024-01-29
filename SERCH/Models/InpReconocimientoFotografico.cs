using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpReconocimientoFotografico
{
    public string InpFolio { get; set; } = null!;

    public short InpRecFolio { get; set; }

    public string? InpRecId { get; set; }

    public DateTime? InpRecFec { get; set; }

    public short? InpRecCond { get; set; }

    public string? InpRecUni { get; set; }

    public string? InpRecFunIns { get; set; }

    public DateTime? InpRecFchHoraIns { get; set; }

    public string? InpRecIpins { get; set; }

    public string? InpRecUpdUni { get; set; }

    public string? InpRecFunUpd { get; set; }

    public DateTime? InpRecFchHoraUpd { get; set; }

    public string? InpRecIpupd { get; set; }

    public string? InpRecNomConCat { get; set; }

    public string? InpRecInvConCat { get; set; }
}
