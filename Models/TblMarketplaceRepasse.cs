using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblMarketplaceRepasse
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public DateTime? Data { get; set; }

    public string? Json { get; set; }
}
