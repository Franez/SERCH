using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasProgReha
{
    public string UperId { get; set; } = null!;

    public short UniCodProgReha { get; set; }

    public string UniNomProgReha { get; set; } = null!;

    public string? UniEstProgReha { get; set; }
}
