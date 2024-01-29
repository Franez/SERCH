using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasEmail
{
    public string UperId { get; set; } = null!;

    public string UperEmail { get; set; } = null!;

    public string? UperEmailVig { get; set; }

    public string? UperEmailPrin { get; set; }
}
