using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblNfeErro
{
    public int Id { get; set; }

    public string? Pedido { get; set; }

    public string? Usuario { get; set; }

    public string? Xmotivo { get; set; }

    public DateTime? Data { get; set; }
}
