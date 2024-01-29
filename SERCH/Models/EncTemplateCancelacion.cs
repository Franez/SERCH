using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EncTemplateCancelacion
{
    public int EncCanTemNro { get; set; }

    public string? EncCanTemDes { get; set; }

    public short? EncCanTemOrgCod { get; set; }

    public int? EncCanTemOrgDetCod { get; set; }

    public string? EncCanTemDocCod { get; set; }

    public decimal? EncCanTemNroDoc { get; set; }

    public DateTime? EncCanTemFecDoc { get; set; }

    public int? EncCanTemUsuIns { get; set; }

    public DateTime? EncCanTemFecIns { get; set; }

    public string? EncCanTemUni { get; set; }
}
