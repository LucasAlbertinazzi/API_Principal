using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblRotinaItensAval
{
    public int? CodRotina { get; set; }

    public int? CodItem { get; set; }

    public int? Nota { get; set; }

    public string? Obs { get; set; }

    public int CodItemAval { get; set; }

    public int? CodUsuario { get; set; }
}
