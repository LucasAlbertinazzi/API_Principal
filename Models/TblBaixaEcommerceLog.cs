using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblBaixaEcommerceLog
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public int? Usuario { get; set; }

    public string? Json { get; set; }
}
