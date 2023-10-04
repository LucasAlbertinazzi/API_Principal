using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblLogAtualizaRomaneio
{
    public int Id { get; set; }

    public long? LoginUser { get; set; }

    public DateTime? Date { get; set; }

    public string? Documento { get; set; }

    public long? Codcliente { get; set; }
}
