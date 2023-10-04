using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblProjetoVp
{
    public int Codigo { get; set; }

    public int? CodGrupoFornecedor { get; set; }

    public short? Ano { get; set; }

    public decimal? Porcentagem { get; set; }

    public bool? SomarImposto { get; set; }
}
