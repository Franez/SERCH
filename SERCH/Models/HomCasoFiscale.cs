using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoFiscale
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short HomFisNro { get; set; }

    public string? HomFisCasoId { get; set; }

    public DateTime? HomFisCasoFecIni { get; set; }

    public DateTime? HomFisCasoFecTer { get; set; }

    public short? HomFisCasoVig { get; set; }
}
