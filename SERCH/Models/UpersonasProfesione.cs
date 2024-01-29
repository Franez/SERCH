using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasProfesione
{
    public string UperId { get; set; } = null!;

    public short UperProfCod { get; set; }

    public string? UperProfPrin { get; set; }

    public string? UperProfVig { get; set; }
}
