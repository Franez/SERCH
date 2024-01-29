using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpControlIdentidad
{
    public int InpCtrlFolio { get; set; }

    public DateTime? InpCtrlFecha { get; set; }

    public short? InpCtrlAnio { get; set; }

    public short? InpCtrlMes { get; set; }

    public DateTime? InpCtrlHora { get; set; }

    public int InpCtrlInvFolio { get; set; }

    public string? InpCtrlUniCod { get; set; }

    public int? InpCtrlFunRut { get; set; }

    public string? InpCtrlComCod { get; set; }

    public string? InpCtrlDetalles { get; set; }

    public string? InpCtrlFunIns { get; set; }

    public DateTime? InpCtrlHrsIns { get; set; }

    public string? InpCtrlWrkIns { get; set; }

    public string? InpCtrlUniIns { get; set; }

    public string? InpCtrlFunUpd { get; set; }

    public DateTime? InpCtrlHrsUpd { get; set; }

    public string? InpCtrlWrkUpd { get; set; }

    public string? InpCtrlUniUpd { get; set; }
}
