using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomGrupoTrabajo
{
    public string HomUniCod { get; set; } = null!;

    public short HomGruCod { get; set; }

    public short? HomGruVig { get; set; }

    public string? HomGruDes { get; set; }

    public string? HomGruUsuIns { get; set; }

    public DateTime? HomGruFecUpd { get; set; }

    public DateTime? HomGruFecIns { get; set; }

    public string? HomGruUsuUpd { get; set; }

    public int? HomGruFunJefe { get; set; }
}
