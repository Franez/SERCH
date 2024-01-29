using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Odontograma
{
    public short OdonCod { get; set; }

    public string? OdonDes { get; set; }

    public byte[]? OdonFoto { get; set; }
}
