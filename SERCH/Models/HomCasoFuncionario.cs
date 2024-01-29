using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoFuncionario
{
    public int HomFolio { get; set; }

    public short HomAno { get; set; }

    public int HomFunIdCaso { get; set; }

    public short? HomFunExFlg { get; set; }

    public short? HomFunCarFlg { get; set; }

    public short? HomFunOrder { get; set; }
}
