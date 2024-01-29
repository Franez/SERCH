using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniInstruccionVerbal
{
    public string InpFolio { get; set; } = null!;

    public int UniInsVerFol { get; set; }

    public DateTime? UniInsVerFre { get; set; }

    public DateTime? UniInsVerHre { get; set; }

    public string? UniInsVerTdo { get; set; }

    public short? UniInsVerTde { get; set; }

    public short? UniInsVerCde { get; set; }

    public short? UniInsVerTor { get; set; }

    public short? UniInsVerCor { get; set; }

    public string? UniInsVerRuc { get; set; }

    public string? UniInsVerRit { get; set; }

    public string? UniInsVerIdF { get; set; }

    public string? UniInsVerDet { get; set; }

    public string? UniInsVerObs { get; set; }
}
