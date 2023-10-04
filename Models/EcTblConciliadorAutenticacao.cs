using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class EcTblConciliadorAutenticacao
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public int? TempExp { get; set; }

    public DateTime? Date { get; set; }

    public bool? Status { get; set; }
}
