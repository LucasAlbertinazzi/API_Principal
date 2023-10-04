using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblVersaoSistema
{
    public int Id { get; set; }

    public string Hash { get; set; } = null!;

    public DateTime Data { get; set; }
}
