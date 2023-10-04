using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblForneContaDominio
{
    public long Codigo { get; set; }

    public string? Descricao { get; set; }

    public string ClassificacaoContabil { get; set; } = null!;
}
