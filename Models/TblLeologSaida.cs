using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblLeologSaida
{
    public int Id { get; set; }

    public string Pedido { get; set; } = null!;

    public string? ArquivoConferencia { get; set; }

    public string? ArquivoSolicitado { get; set; }

    public int Codusuario { get; set; }
}
