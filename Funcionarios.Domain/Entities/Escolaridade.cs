﻿using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class Escolaridade : BaseEntity
    {
        public int EscolaridadeId { get; set; }
        public string Descricao { get; set; }
        public bool Inativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}
