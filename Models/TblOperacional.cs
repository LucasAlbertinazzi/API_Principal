using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblOperacional
{
    public int Codigo { get; set; }

    public int? Loja { get; set; }

    public string? Mes { get; set; }

    public decimal? Valorloja { get; set; }

    public decimal? Valorlojadep { get; set; }
}
