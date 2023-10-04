using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblGeraRomaneio
{
    public long Codromaneio { get; set; }

    public string? Documento { get; set; }

    public string? Tipo { get; set; }

    public char? EntregaAssist { get; set; }
}
