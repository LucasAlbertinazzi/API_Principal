using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblLogAnexo
{
    public int Id { get; set; }

    public string? Categoria { get; set; }

    public DateTime? Datahora { get; set; }

    public int? Codusuario { get; set; }

    public string? Alteracao { get; set; }
}
