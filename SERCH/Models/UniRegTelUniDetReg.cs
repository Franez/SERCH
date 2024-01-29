using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniRegTelUniDetReg
{
    public decimal UniIdTegTel { get; set; }

    public short UniDetRegTel { get; set; }

    public int? UniFunSolDet { get; set; }

    public DateTime? UniFchSolTelDet { get; set; }
}
