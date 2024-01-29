using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesMedida
{
    public int GesMedCod { get; set; }

    public string? GesMedDes { get; set; }

    public short? GesMedDesTipo { get; set; }

    public short? GesMedUniTipo { get; set; }

    public short? GesMedClase { get; set; }

    public short? GesMedIngreso { get; set; }

    public short? GesMedModoIng { get; set; }

    public short? GesMedActivo { get; set; }

    public string? GesMedTxtExp { get; set; }

    public short? GesMedCavas { get; set; }
}
