using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUnidadGenerica
{
    public string GesGenUniCod { get; set; } = null!;

    public string? GesGenUniDes { get; set; }

    public short? GesGenActivo { get; set; }

    public string? GesGenRegCod { get; set; }

    public short? GesGenCiuCod { get; set; }

    public string? GesCodGepol { get; set; }

    public string? GesGenUniAbv { get; set; }

    public string? GesGenComCod { get; set; }

    public short? GesGenRmges { get; set; }

    public short? GesGenRgnGes { get; set; }

    public string? UniTipoCod { get; set; }

    public int? GesCodSia { get; set; }

    public short? GesGenFusFlg { get; set; }

    public string? GesGenCodArea { get; set; }

    public string? GesGenDirNom { get; set; }

    public string? GesGenDirNro { get; set; }

    public string? GesGenEmail { get; set; }

    public short? GesGenJefGes { get; set; }

    public short? TipEspPolCod { get; set; }

    public int? Gescodalma { get; set; }

    public short? Gesgensegdec { get; set; }
}
