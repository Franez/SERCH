using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Arma
{
    public string ArmCod { get; set; } = null!;

    public string? ArmDes { get; set; }

    public short TipArmCod { get; set; }

    public short MarArmCod { get; set; }

    public string? ArmModelo { get; set; }

    public short? ArmCalibre { get; set; }

    public short? ArmPaiCod { get; set; }

    public short? ArmAno { get; set; }

    public short? ArmPeriodo { get; set; }

    public byte[]? ArmFoto { get; set; }
}
