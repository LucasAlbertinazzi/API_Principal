using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblChecklistAtividadeFinalizado
{
    public int? IdChecklistatividade { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? Data { get; set; }

    public int Id { get; set; }
}
