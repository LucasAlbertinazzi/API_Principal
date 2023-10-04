using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblOcorrServico
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public bool? Ativo { get; set; }

    public int? Coddep { get; set; }
}
