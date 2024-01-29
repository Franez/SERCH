using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCaso
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short? HomStatus { get; set; }

    public string? HomCasoDes { get; set; }

    public DateTime? HomCasoFec { get; set; }

    public DateTime? HomCasoHrsCall { get; set; }

    public short? HomTipHomCod { get; set; }

    public string? HomPerFisId { get; set; }

    public short? HomOrgCod { get; set; }

    public int? HomOrgDetCod { get; set; }

    public int? HomCasoFunIns { get; set; }

    public string? HomCasoComCod { get; set; }

    public string? HomCasoPrvCod { get; set; }

    public string? HomCasoRegCod { get; set; }

    public string? HomCasoCalleCod { get; set; }

    public string? HomCasoCalleDes { get; set; }

    public short? HomCasoCalleTipo { get; set; }

    public string? HomCasoNroDom { get; set; }

    public string HomUniCod { get; set; } = null!;

    public short? HomGruCod { get; set; }

    public string? HomCasoObs { get; set; }

    public string? HomCasoInsOcu { get; set; }

    public DateTime? HomCasoFecCon { get; set; }

    public string? HomCasoUsuIns { get; set; }

    public string? HomCasoUsuUpd { get; set; }

    public DateTime? HomCasoHrsIns { get; set; }

    public DateTime? HomCasoHrsUpd { get; set; }

    public string? HomCasoWrkIns { get; set; }

    public string? HomCasoWrkUpd { get; set; }
}
