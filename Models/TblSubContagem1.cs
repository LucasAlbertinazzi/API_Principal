﻿using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblSubContagem1
{
    public int Codigo { get; set; }

    public string Codproduto { get; set; } = null!;

    public int Idetiqueta { get; set; }

    public string? Volume { get; set; }

    public DateTime? Data { get; set; }

    public int Codcontagem { get; set; }

    public int? Quant { get; set; }
}