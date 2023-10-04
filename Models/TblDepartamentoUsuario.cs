using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblDepartamentoUsuario
{
    public int Id { get; set; }

    public string? NomeDep { get; set; }

    public TimeOnly Data { get; set; }
}
