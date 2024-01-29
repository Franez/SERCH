using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasOdontograma
{
    public string UperId { get; set; } = null!;

    public short OdonCod { get; set; }

    public short? UperOdonFlg { get; set; }

    public string? UperOdonTxt { get; set; }
}
