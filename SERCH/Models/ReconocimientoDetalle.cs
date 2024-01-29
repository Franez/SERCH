using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ReconocimientoDetalle
{
    public decimal RecVisFolio { get; set; }

    public string RecVisUperId { get; set; } = null!;

    public decimal RecVisFotoPor { get; set; }
}
