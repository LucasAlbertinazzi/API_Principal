using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblPosicaoProd
{
    public int Codigo { get; set; }

    public int? Usuario { get; set; }

    public int? CodPosicao { get; set; }

    public string? Codproduto { get; set; }

    public DateTime? DataHora { get; set; }

    public virtual TblPosicao? CodPosicaoNavigation { get; set; }
}
