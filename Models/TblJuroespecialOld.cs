using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblJuroespecialOld
{
    public long Codigo { get; set; }

    /// <summary>
    /// Condição de pagamento
    /// </summary>
    public long? Condicao { get; set; }

    /// <summary>
    /// Taxa de juro
    /// </summary>
    public double? Juro { get; set; }

    public string? Codproduto { get; set; }
}
