using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

/// <summary>
/// Armazena os Produtos na Skyhub 
/// </summary>
public partial class EcTblProdutoMk
{
    public string Codproduto { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? SkuSky { get; set; }

    public string? Ean { get; set; }
}
