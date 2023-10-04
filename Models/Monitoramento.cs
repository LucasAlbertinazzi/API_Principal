using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class Monitoramento
{
    public int Id { get; set; }

    public string Tabela { get; set; } = null!;

    public string Operacao { get; set; } = null!;

    public DateTime DataHora { get; set; }

    public string? Informacoes { get; set; }
}
