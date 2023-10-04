using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblRecebimentoContabil
{
    public int Id { get; set; }

    public long? Codigo { get; set; }

    public decimal? Valor { get; set; }

    public string? Obs { get; set; }

    public string? ContaCredito { get; set; }

    public string? ContaDebito { get; set; }

    public DateTime? DataExtrato { get; set; }

    public DateTime? DataGrav { get; set; }
}
