using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniGooglemap
{
    public string UniGoogleKey { get; set; } = null!;

    public decimal UniGoogleCount { get; set; }

    public DateTime? UniGoogleUpdate { get; set; }
}
