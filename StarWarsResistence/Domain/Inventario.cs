using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MediatorSimples.Domain
{
    public class Inventario : BaseDomain
    {
        public List<ItensInventario> Itens { get; set; }
    }
}
