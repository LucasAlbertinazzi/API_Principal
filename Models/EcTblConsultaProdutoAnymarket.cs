using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class EcTblConsultaProdutoAnymarket
{
    public int Id { get; set; }

    public int Codloja { get; set; }

    public DateTime Datainicio { get; set; }

    public DateTime? Datafim { get; set; }
}
