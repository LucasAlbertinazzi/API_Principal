﻿using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblLogParcelasPaga
{
    public int Id { get; set; }

    public DateTime? Datahora { get; set; }

    public long? Codusuario { get; set; }

    public long? Codcliente { get; set; }

    public string? Justificativa { get; set; }

    public string? Informacoes { get; set; }
}
