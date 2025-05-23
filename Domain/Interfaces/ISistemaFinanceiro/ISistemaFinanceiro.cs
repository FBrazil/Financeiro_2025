﻿using Domain.Interfaces.Genereics;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ISistemaFinanceiro
{
    public interface ISistemaFinanceiro : InterfaceGeneric<SistemaFinanceiro>
    {
        Task<IList<SistemaFinanceiro>> ListarSistemasUsuario(string emailUsuario);
    }
}
