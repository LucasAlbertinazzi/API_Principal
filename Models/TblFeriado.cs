using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblFeriado
{
    public DateOnly Data { get; set; }

    public string? Descricao { get; set; }
}
