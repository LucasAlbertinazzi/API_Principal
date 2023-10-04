using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblBancoCliente
{
    public int Codigo { get; set; }

    public string? Banco { get; set; }

    public string? Agencia { get; set; }

    public string? Contacorrente { get; set; }

    public string? Abertura { get; set; }

    public int? Codcliente { get; set; }
}
