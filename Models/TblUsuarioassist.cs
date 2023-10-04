using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblUsuarioassist
{
    public int Codusuario { get; set; }

    public string? Nome { get; set; }

    public string? Login { get; set; }

    public string? Senha { get; set; }

    public int Nivel { get; set; }
}
