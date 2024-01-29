using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniPargen
{
    public short UniCodParGen { get; set; }

    public string UniCodParAmbiente { get; set; } = null!;

    public decimal? UniUltLinCod { get; set; }

    public decimal? UniContador { get; set; }

    public short? UniRegCivil { get; set; }

    public string? UniAvisoV2 { get; set; }

    public string? UniClaveGoogle { get; set; }

    public string? UniPredes { get; set; }

    public string? UniEleConPriDil { get; set; }

    public string? UniEleConDenun { get; set; }

    public string? UniVersionNav { get; set; }

    public string? UniUserServRegc { get; set; }

    public DateTime? UniFechaActualizaEstadis { get; set; }

    public string? UniUsuConRegCiv { get; set; }

    public string? UniPassConRgCiv { get; set; }

    public string? UniIpConRegCiv { get; set; }

    public short? UniPuertoConRegCiv { get; set; }

    public string? UniEncVifact { get; set; }

    public string? UniEncVifserv { get; set; }

    public short? UniEncVifpuerto { get; set; }

    public string? UniEncVifburl { get; set; }

    public string? UniEncVifrname { get; set; }

    public short? UniEncVifburlTout { get; set; }

    public int? UniCantRegistros { get; set; }

    public DateTime? UniFecCorInf { get; set; }

    public DateTime? UniUserServRegctc { get; set; }

    public string? UniTelConBrain { get; set; }

    public short? UniAnnoFolUni { get; set; }

    public string? UniFolUniAct { get; set; }

    public decimal? UniFolUniCorr { get; set; }

    public decimal? UniUltUperid { get; set; }

    public string? UniBrainAct { get; set; }

    public DateTime? UniBrainFechProc { get; set; }

    public string? UniUrlPaso { get; set; }

    public decimal? UniCorrIndoc { get; set; }

    public string? UniUrlChatBot { get; set; }
}
