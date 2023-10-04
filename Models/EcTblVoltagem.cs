using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

/// <summary>
/// Voltagem dos Produtos no E-commerce
/// </summary>
public partial class EcTblVoltagem
{
    public short Codigo { get; set; }

    public string? Voltagem { get; set; }
}
