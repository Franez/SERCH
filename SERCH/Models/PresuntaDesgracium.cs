using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PresuntaDesgracium
{
    public short PreDesAno { get; set; }

    public int PreDesFolio { get; set; }

    public string? PreDesUni { get; set; }

    public DateTime? PreDesFec { get; set; }

    public DateTime? PreDesFecTer { get; set; }

    public string? PreDesFun { get; set; }

    public DateTime? PreFecHoraIng { get; set; }

    public string? PreDesFunUpd { get; set; }

    public DateTime? PreDesFecUpd { get; set; }

    public string? PreDesReg { get; set; }

    public string? PreDesProvCod { get; set; }

    public string? PreDesComCod { get; set; }

    public string? PreDesDir { get; set; }

    public string? PreDesCalle1 { get; set; }

    public string? PreDesCalle2 { get; set; }

    public string? PreDesObs { get; set; }

    public string? PreDesUperId { get; set; }

    public string? PreDesUperDenId { get; set; }
}
