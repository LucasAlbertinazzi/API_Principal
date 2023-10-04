using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblPromessa
{
    public int Codigo { get; set; }

    public DateOnly? Pgtopara { get; set; }

    public DateTime? Datapromessa { get; set; }

    public string? Prometidopor { get; set; }

    public int? Codusuario { get; set; }

    public long? Codcliente { get; set; }
}
