using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasAntMig
{
    public string UperId { get; set; } = null!;

    public short UperCorrAntM { get; set; }

    public DateTime? UperFecIngAntM { get; set; }

    public string? UperCondIngAntM { get; set; }

    public string? UperCondResAntM { get; set; }

    public string? UperTipVisAntM { get; set; }

    public string? UperNumResDoc { get; set; }

    public DateTime? UperFecResDoc { get; set; }

    public DateTime? UperFecVenDoc { get; set; }

    public string? UperLigIngAntM { get; set; }

    public string? UperAutoOrtor { get; set; }

    public string? UperTipIngPai { get; set; }

    public DateTime? UperFecIngEst { get; set; }

    public string? UperForIngEst { get; set; }

    public string? UperMedTransEst { get; set; }

    public short? UperAcomEst { get; set; }

    public decimal? UperDinPagEst { get; set; }

    public string? UperPerPagEst { get; set; }

    public string? UperNumTimMigEst { get; set; }

    public string? UperRunEmpAntM { get; set; }

    public string? UperDivPag { get; set; }

    public string? UperNomDueResAnt { get; set; }

    public string? UperNomAcomAntMig { get; set; }

    public DateTime? UperFecIngAntM2 { get; set; }

    public DateTime? UperFecIngEst2 { get; set; }

    public string? UperAntMigVinculoPais { get; set; }

    public string? UpeAntMigVictima { get; set; }

    public string? UperAntMigAcomPar { get; set; }

    public string? UperAntIngDocu { get; set; }

    public short? UperAntMigCantMen { get; set; }

    public string? UperAntmigFlagDet { get; set; }

    public string? UperAntmigFlag { get; set; }
}
