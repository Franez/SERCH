using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoMemo
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short HomMemoFolio { get; set; }

    public string? HomMemoNro { get; set; }

    public DateTime? HomMemoFec { get; set; }

    public short? HomMemoTipo { get; set; }

    public string? HomMemoMat { get; set; }

    public string? HomMemoDil { get; set; }

    public string? HomMemoRes { get; set; }

    public int? HomMemoFunFirRut { get; set; }

    public string? HomMemoUsuIns { get; set; }

    public DateTime? HomMemoFecIns { get; set; }

    public string? HomMemoWrkIns { get; set; }

    public string? HomMemoUsuUpd { get; set; }

    public DateTime? HomMemoFecUpd { get; set; }

    public string? HomMemoWrkUpd { get; set; }
}
