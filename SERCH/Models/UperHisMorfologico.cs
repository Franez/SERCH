using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperHisMorfologico
{
    public string UperId { get; set; } = null!;

    public short HtrMrfNroLin { get; set; }

    public short? HtrMrfAltMtr { get; set; }

    public decimal? HtrMrfPesoKgr { get; set; }

    public short? HtrMrfTipCabCod { get; set; }

    public short? HtrMrfColCabCod { get; set; }

    public short? HtrMrfTipCabelCod { get; set; }

    public short? HtrMrfColOjoCod { get; set; }

    public short? HtrMrfConTexCod { get; set; }

    public short? HtrMrfTipCarCod { get; set; }

    public short? HtrMrfTipFreCod { get; set; }

    public short? HtrMrfTipPielCod { get; set; }

    public short? HtrMrfTipNarizCod { get; set; }

    public short? HtrMrfVozCod { get; set; }

    public short? HtrMrfTipOrecCod { get; set; }

    public short? HtrMrfTipoMenCod { get; set; }

    public short? HtrMrfTipoBocCod { get; set; }

    public string? HtrMrfSexo { get; set; }

    public string? HtrMrfMasObs { get; set; }

    public short? HtrMrfFlgIng { get; set; }

    public int? HtrMrfFunIns { get; set; }

    public DateTime? HtrMrfFunInsFch { get; set; }

    public int? HtrMrfFunUpd { get; set; }

    public DateTime? HtrMrfFunUpdFch { get; set; }

    public short? HtrMrfDepIng { get; set; }
}
