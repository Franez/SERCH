using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoFoto
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short HomFotoNro { get; set; }

    public byte[]? HomFotoPic { get; set; }

    public string? HomFotoDesc { get; set; }

    public DateTime? HomFotoFec { get; set; }

    public string? HomFotoUsuIns { get; set; }

    public string? HomFotoUsuUpd { get; set; }

    public string? HomFotoWrkIns { get; set; }

    public string? HomFotoWrkUpd { get; set; }

    public DateTime? HomFotoFchIns { get; set; }

    public DateTime? HomFotoFchUpd { get; set; }
}
