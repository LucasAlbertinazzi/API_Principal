using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblMarketing
{
    public int Id { get; set; }

    public string? Promocao { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public string? Login { get; set; }
}
