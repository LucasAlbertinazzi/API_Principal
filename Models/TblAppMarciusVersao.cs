using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblAppMarciusVersao
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Versao { get; set; }
}
