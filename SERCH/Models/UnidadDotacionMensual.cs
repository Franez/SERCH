using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UnidadDotacionMensual
{
    public string GesGenUniCod { get; set; } = null!;

    public short UniDotAnio { get; set; }

    public short UniDotMes { get; set; }

    public short? UniDotOpcant { get; set; }

    public short? UniDotOpadmCant { get; set; }

    public short? UniDotApcant { get; set; }

    public short? UniDotApadmCant { get; set; }

    public short? UniDotAgcant { get; set; }

    public short? UniDotAdmcant { get; set; }

    public string? UniDotUsuIns { get; set; }

    public DateTime? UniDotFecIns { get; set; }

    public string? UniDotWrkIns { get; set; }

    public string? UniDotUsuUpd { get; set; }

    public DateTime? UniDotFecUpd { get; set; }

    public string? UniDotWrkUpd { get; set; }
}
