using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperDetencionesLevel1
{
    public string UperId { get; set; } = null!;

    public string UperUniDet { get; set; } = null!;

    public decimal UperUniParte { get; set; }

    public short? UperOrgCod { get; set; }

    public int? UperOrgDetNro { get; set; }

    public DateTime? UperDetFecPar { get; set; }

    public short? UperDetAno { get; set; }

    public short? UperDetMes { get; set; }

    public string? UperDetAseNro { get; set; }

    public DateTime? UperDetFecIng { get; set; }

    public string? UperDetFunIns { get; set; }

    public string? UperDetFunUpd { get; set; }

    public DateTime? UperDetFecUpd { get; set; }

    public short? ReaDelCod { get; set; }

    public string ReaDelDes { get; set; } = null!;

    public int? UperDetUltLinDel { get; set; }

    public string? UperFilUniCod { get; set; }

    public string? UperDetComCod { get; set; }

    public string? UperDetRegCod { get; set; }

    public short? UperDetVig { get; set; }

    public DateTime? UperDetHora { get; set; }
}
