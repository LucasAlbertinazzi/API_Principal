using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblBilheteGarantiaRetorno
{
    public string Arquivo { get; set; } = null!;

    public DateTime? DataRetorno { get; set; }
}
