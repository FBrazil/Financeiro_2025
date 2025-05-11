﻿using Domain.Interfaces.ISistemaFinanceiro;
using Entities.Entidades;
using Infra.Repositorio.Generics;

namespace Infra.Repositorio;

public class RepositorioSistemaFinanceiro : RepositoryGenerics<SistemaFinanceiro>, ISistemaFinanceiro
{
    public Task<IList<SistemaFinanceiro>> ListarSistemasUsuario(string emailUsuario)
    {
        throw new NotImplementedException();
    }
}
