﻿using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblMensagemDel
{
    public int Codigo { get; set; }

    public int? Codreme { get; set; }

    public int? Coddest { get; set; }

    public string? Assunto { get; set; }

    public string? Mensagem { get; set; }

    public DateTime? Data { get; set; }

    public char? Lida { get; set; }

    public int Id { get; set; }

    public string? Destinatarios { get; set; }

    public virtual TblUsuario? CoddestNavigation { get; set; }

    public virtual TblUsuario? CodremeNavigation { get; set; }
}
