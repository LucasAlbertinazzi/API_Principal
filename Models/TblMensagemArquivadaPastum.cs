using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblMensagemArquivadaPastum
{
    public int Id { get; set; }

    public int? Codusuario { get; set; }

    public string? Nome { get; set; }
}
