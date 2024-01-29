using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAudiInterpol
{
    public decimal UniAudiIplRutFun { get; set; }

    public string UperId { get; set; } = null!;

    public DateTime UniAudiIplFecha { get; set; }

    public string? UniAudiIplWrkIng { get; set; }

    public short? UniAudiIplTpoIng { get; set; }

    public short? UniAudiIplAno { get; set; }

    public short? UniAudiIplMes { get; set; }

    public short? UniAudiIplDia { get; set; }

    public short? UniAudiIplSs { get; set; }

    public short? UniAudiIplHh { get; set; }

    public short? UniAudiIplMm { get; set; }

    public string? UniAudiIplInfo { get; set; }

    public string? UniAudiIplUni { get; set; }
}
