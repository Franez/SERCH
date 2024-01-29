using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniNoticia
{
    public short UniNotCod { get; set; }

    public string? UniNotNot { get; set; }

    public string? UniNotLink { get; set; }

    public string? UniNotNoL { get; set; }

    public string? UniNotVig { get; set; }

    public DateTime? UniNotFec { get; set; }

    public short? UniNotTip { get; set; }

    public string? UniNotCom { get; set; }
}
