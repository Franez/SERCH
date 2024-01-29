using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoEndoso
{
    public string InpFolio { get; set; } = null!;

    public short InpEndNro { get; set; }

    public DateTime? InpEndFec { get; set; }

    public short? InpEndStatus { get; set; }

    public int? InpEndFunAsg { get; set; }

    public int? InpEndFunRec { get; set; }

    public short? InpEndDiasPla { get; set; }

    public short? InpEndDiasRealCan { get; set; }

    public string? InpEndObsEnd { get; set; }

    public DateTime? InpEndFecVen { get; set; }

    public string? InpEndUniEnd { get; set; }

    public string? InpEndResDocTipo { get; set; }

    public string? InpEndResDocAut { get; set; }

    public decimal? InpEndResDocNro { get; set; }

    public string? InpEndResDocLet { get; set; }

    public DateTime? InpEndResDocFec { get; set; }

    public string? InpEndResGenInf { get; set; }

    public DateTime? InpEndFecIns { get; set; }

    public string? InpEndWrkIns { get; set; }

    public string? InpEndFunIns { get; set; }

    public short? InpEndResCod { get; set; }

    public string? InpEndWrkCan { get; set; }

    public DateTime? InpEndFecCan { get; set; }

    public string? InpEndFunCan { get; set; }

    public string? InpEndAmplia { get; set; }

    public string? InpNumEndoso { get; set; }

    public string? InpEndUniAlmaEnd { get; set; }
}
