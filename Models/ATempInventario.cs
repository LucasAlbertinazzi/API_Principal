using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class ATempInventario
{
    public int Id { get; set; }

    public string? Codproduto { get; set; }

    public string? Descricao { get; set; }

    public decimal? Quant { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Total { get; set; }
}
