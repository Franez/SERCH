using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class FuncionariosDomicilio
{
    public int PerFunRut { get; set; }

    public short PerFunDomNro { get; set; }

    public string? PerFunDomComCod { get; set; }

    public string? PerFunDomRegCod { get; set; }

    public string? PerFunDomPrvCod { get; set; }

    public string? PerFunDomVilCod { get; set; }

    public string? PerFunDomCalleCod { get; set; }

    public short? PerFunDomCalleTipo { get; set; }

    public string? PerFunDomCalleDes { get; set; }

    public string? PerFunDomCalleNro { get; set; }

    public string? PerFunDomDptoNro { get; set; }

    public string? PerFunDomUsuIns { get; set; }

    public string? PerFunDomUsuUpd { get; set; }

    public DateTime? PerFunDomFecIns { get; set; }

    public DateTime? PerFunDomFecUpd { get; set; }

    public string? PerFunDomWrkIns { get; set; }

    public string? PerFunDomWrkUpd { get; set; }
}
