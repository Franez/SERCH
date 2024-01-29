using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EncAuditoriaIng
{
    public int PerFunRut { get; set; }

    public decimal EncAudFolio { get; set; }

    public DateTime? EncAudFunHrs { get; set; }

    public string? EncAudIpIng { get; set; }

    public string? EncAudWrkIng { get; set; }

    public string? EncAudAccion { get; set; }

    public string? EncAudUperId { get; set; }

    public short? EncAudFolioEnc { get; set; }
}
