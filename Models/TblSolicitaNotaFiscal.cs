using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblSolicitaNotaFiscal
{
    public int Id { get; set; }

    public int NfeId { get; set; }

    public int Usuario { get; set; }

    public string? Descricao { get; set; }

    public DateTime Data { get; set; }
}
