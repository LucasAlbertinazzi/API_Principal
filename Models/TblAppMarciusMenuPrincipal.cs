using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblAppMarciusMenuPrincipal
{
    public int Id { get; set; }

    public string? TextoBtn { get; set; }

    public string? NomeMetodo { get; set; }

    public bool? BtnAtivo { get; set; }

    public string? DepPermitidos { get; set; }

    public DateTime? Data { get; set; }

    public string? CodIcone { get; set; }
}
