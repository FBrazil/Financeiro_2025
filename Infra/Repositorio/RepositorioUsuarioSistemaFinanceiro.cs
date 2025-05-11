using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entidades;
using Infra.Repositorio.Generics;

namespace Infra.Repositorio;

public class RepositorioUsuarioSistemaFinanceiro : RepositoryGenerics<UsuarioSistemaFinanceiro>, InterfaceUsuarioSistemaFinanaceiro
{
    public Task<IList<UsuarioSistemaFinanceiro>> ListarUsuarioSistema(int IdSistema)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario)
    {
        throw new NotImplementedException();
    }

    public Task RemoverUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
    {
        throw new NotImplementedException();
    }
}
