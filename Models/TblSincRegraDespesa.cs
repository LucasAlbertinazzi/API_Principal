using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblSincRegraDespesa
{
    public int Id { get; set; }

    public int TipoNota { get; set; }

    public DateTime Data { get; set; }
}
