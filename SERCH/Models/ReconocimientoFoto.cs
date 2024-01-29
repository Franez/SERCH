using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ReconocimientoFoto
{
    public decimal RecVisFolio { get; set; }

    public string? RecVisId { get; set; }

    public string? RecVisUniEnv { get; set; }

    public int? RecVisFisCod { get; set; }

    public int? RecVisTriCod { get; set; }

    public DateTime? RecVisFec { get; set; }

    public string? RecVisModus { get; set; }

    public int? RecVisDelCod { get; set; }

    public string? RecRegCod { get; set; }

    public string? RecProCod { get; set; }

    public string? RecComCod { get; set; }

    public string? RecCallePrin { get; set; }

    public string? RecCalleRef1 { get; set; }

    public string? RecCalleRef2 { get; set; }

    public string? RecFunRutIns { get; set; }

    public DateTime? RecFunDateIns { get; set; }

    public string? RecFunRutUpd { get; set; }

    public DateTime? RecFunDateUpd { get; set; }

    public short? RecOrgCod { get; set; }

    public int? RecDetOrgNro { get; set; }
}
