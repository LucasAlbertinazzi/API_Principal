using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblMotivosNaocarregado
{
    public int Codigo { get; set; }

    public string? Motivo { get; set; }

    public char? Ativo { get; set; }
}
