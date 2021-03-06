﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyManager.Dominio.Entidades
{
    public class GrupoDeUsuario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

        public int NivelDeAcessoId { get; set; }
        public virtual NivelDeAcesso NivelDeAcesso { get; set; }
    }
}
