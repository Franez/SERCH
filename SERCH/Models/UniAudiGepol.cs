using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAudiGepol
{
    public decimal UniAudiGplRutFun { get; set; }

    public string UperId { get; set; } = null!;

    public DateTime UniAudiGplFecha { get; set; }

    public string? UniAudiGplWrkIng { get; set; }

    public short? UniAudiGplTpoIng { get; set; }

    public short? UniAudiGplAno { get; set; }

    public short? UniAudiGepolMes { get; set; }

    public short? UniAudiGepolDia { get; set; }

    public short? UniAudiGplSs { get; set; }

    public short? UniAudiGplHh { get; set; }

    public short? UniAudiGplMm { get; set; }

    public string? UniAudiGplInfo { get; set; }

    public string? UniAudiGepolUni { get; set; }
}
