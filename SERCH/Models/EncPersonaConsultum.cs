using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EncPersonaConsultum
{
    public string EncPerConcat { get; set; } = null!;

    public string EncPerId { get; set; } = null!;

    public string? EncPerNombreCon { get; set; }

    public string? EncPerPaternoCon { get; set; }

    public string? EncPerMaternoCon { get; set; }

    public DateTime? EncPerFecNacCon { get; set; }

    public string? EncPerSexo { get; set; }

    public string? EncPerDniNro { get; set; }

    public string? EncPerDniDv { get; set; }

    public short? EncPerVigencia { get; set; }

    public short? EncPerFlgFun { get; set; }

    public string? EncPerDepFolio { get; set; }
}
