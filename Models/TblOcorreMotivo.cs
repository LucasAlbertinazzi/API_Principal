using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

/// <summary>
/// Motivos das ocorrencias
/// </summary>
public partial class TblOcorreMotivo
{
    public int Codocorrencia { get; set; }

    public string? Motivo { get; set; }
}
