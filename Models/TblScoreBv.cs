﻿using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblScoreBv
{
    public int Codigo { get; set; }

    public long? Codcliente { get; set; }

    public string? Informante { get; set; }

    public string? Instituicao { get; set; }

    public DateOnly? Data { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Dataconsulta { get; set; }

    public string? Tipo { get; set; }

    public char? Excluido { get; set; }

    public string? Situacao { get; set; }

    public string? Stringcompleta { get; set; }
}
