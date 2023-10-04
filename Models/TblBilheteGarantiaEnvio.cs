using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblBilheteGarantiaEnvio
{
    public int Codigo { get; set; }

    public string? NomeArquivo { get; set; }

    public string? Arquivo { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }
}
