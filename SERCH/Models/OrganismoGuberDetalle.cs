using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class OrganismoGuberDetalle
{
    public short OrgCodGub { get; set; }

    public int OrgDetNroGub { get; set; }

    public string? OrgDetDesGub { get; set; }

    public string OrgDetComCodGub { get; set; } = null!;

    public string? RegcodGub { get; set; }

    public string? OrgDetCodAreaGub { get; set; }

    public string? OrgDetDirCalleGub { get; set; }

    public string? OrgDetDirNroGub { get; set; }

    public string? OrgDetEmailGub { get; set; }

    public int? OrgDetDestadGub { get; set; }

    public short? OrgDetComVig { get; set; }
}
