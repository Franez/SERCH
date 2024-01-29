using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoEvidencia
{
    public int HomFolio { get; set; }

    public short HomAno { get; set; }

    public short HomEviNro { get; set; }

    public string? HomEviNue { get; set; }

    public string? HomEviDesc { get; set; }

    public short? HomEviArmFlg { get; set; }

    public string? HomEviArmSerie { get; set; }

    public string? HomEviArmCod { get; set; }

    public string? HomEviUsuIns { get; set; }

    public DateTime? HomEviFecIns { get; set; }

    public string? HomEviWrkIns { get; set; }

    public string? HomEviUsuUpd { get; set; }

    public DateTime? HomEviFecUpd { get; set; }

    public string? HomEviWrkUpd { get; set; }
}
