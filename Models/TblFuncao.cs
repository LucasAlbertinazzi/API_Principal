using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblFuncao
{
    public int Codigo { get; set; }

    public string? Funcao { get; set; }

    public virtual ICollection<TblUsuario> TblUsuarios { get; set; } = new List<TblUsuario>();
}
