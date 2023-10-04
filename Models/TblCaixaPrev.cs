using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblCaixaPrev
{
    public int Id { get; set; }

    public string? Caixa { get; set; }

    public DateOnly? Data { get; set; }

    public short? IdDescricao { get; set; }

    public decimal? Valor { get; set; }

    public short? Codloja { get; set; }

    public short? Indice { get; set; }
}
