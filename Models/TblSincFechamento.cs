using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblSincFechamento
{
    public DateOnly DataFechamento { get; set; }

    public DateTime DataCadastro { get; set; }

    public int Codusuario { get; set; }
}
