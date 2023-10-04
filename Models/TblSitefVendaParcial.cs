using System;
using System.Collections.Generic;

namespace API_AppMarciusMagazine.Models;

public partial class TblSitefVendaParcial
{
    public int IdParcial { get; set; }

    public int CupomFiscal { get; set; }

    public decimal TotalVenda { get; set; }
}
