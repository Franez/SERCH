using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniRelPlasConPai
{
    public string UniPlasUperId { get; set; } = null!;

    public int UniPlasAno { get; set; }

    public decimal UniPlasCorre { get; set; }

    public short UniCodContPai { get; set; }

    public short UniDetCodConPai { get; set; }
}
