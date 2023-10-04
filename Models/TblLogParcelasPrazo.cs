using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblLogParcelasPrazo
{
    public DateTime? Datahora { get; set; }

    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Codpedido { get; set; }
}
