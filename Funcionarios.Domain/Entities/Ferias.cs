﻿using Funcionarios.Domain.Base;
using System;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class Ferias : BaseEntity
    {
        public int FeriasId { get; set; }
        public int FuncionarioId { get; set; }
        //public int PeriodoAquisitivoFeriasId { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool Abono { get; set; }
        public String Descricao { get; set; }
        public bool Efetivado { get; set; }
        public bool Inativo { get; set; }

        public Funcionario Funcionario { get; set; }
        //public PeriodoAquisitivoFerias PeriodoAquisitivoFerias { get; set; }
    }
}
