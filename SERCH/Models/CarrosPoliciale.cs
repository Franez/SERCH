using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class CarrosPoliciale
{
    public string CarrPolId { get; set; } = null!;

    public string? CarrPolDes { get; set; }

    public short? TvhCod { get; set; }

    public short? MarVehCod { get; set; }

    public short? ColCod { get; set; }

    public string? CarrPolModelo { get; set; }

    public string? CarrPolPat { get; set; }

    public string? CarrPolNroCha { get; set; }

    public string? CarrPolNroMot { get; set; }

    public string? CarrPolSigla { get; set; }

    public short? CarrPolAnio { get; set; }

    public decimal? CarrPolNroBien { get; set; }

    public string? CarrPolNroVin { get; set; }

    public int? CarrPolInvCorr { get; set; }
}
