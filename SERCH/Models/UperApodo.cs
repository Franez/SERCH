using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperApodo
{
    public string UperId { get; set; } = null!;

    public int UperApoCod { get; set; }

    public string? UperApoPrin { get; set; }

    public string UperApoVig { get; set; } = null!;
}
