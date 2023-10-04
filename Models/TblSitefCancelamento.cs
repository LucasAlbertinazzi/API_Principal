using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblSitefCancelamento
{
    public int IdCancelamento { get; set; }

    public int CupomVenda { get; set; }

    public int CupomCancelamento { get; set; }
}
