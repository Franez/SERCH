using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoImputado
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short HomImpNro { get; set; }

    public short HomImpRec { get; set; }

    public string? HomImpId { get; set; }

    public int HomImpFunRut { get; set; }

    public DateTime HomImpFecEmp { get; set; }

    public DateTime HomImpHrsIni { get; set; }

    public DateTime HomImpHrsFin { get; set; }

    public string HomImpDec { get; set; } = null!;

    public short? HomImpDetFlg { get; set; }

    public short? HomImpPriFlg { get; set; }
}
