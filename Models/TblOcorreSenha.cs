using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblOcorreSenha
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public int? Nivelsenha { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
