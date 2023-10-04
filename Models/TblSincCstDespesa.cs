using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblSincCstDespesa
{
    public int Id { get; set; }

    public int Cfop { get; set; }

    public int Cst { get; set; }

    public string? CstsOriginal { get; set; }
}
