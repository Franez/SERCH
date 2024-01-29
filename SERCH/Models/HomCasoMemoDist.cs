using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoMemoDist
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short HomMemoFolio { get; set; }

    public string HomMemoUniDis { get; set; } = null!;

    public short HomMemoUniCan { get; set; }
}
