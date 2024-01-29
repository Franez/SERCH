using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniUnidadPeritaje
{
    public short UniIdJefPer { get; set; }

    public short UniIdUniPer { get; set; }

    public short UniPeriCod { get; set; }

    public string? UniNomUniPer { get; set; }

    public string? UniPeriTipo { get; set; }

    public string? UniPeriDesc { get; set; }

    public short? UniVigPer { get; set; }

    public short? UniPeriVigencia { get; set; }

    public string? UniReqNueUniPer { get; set; }
}
