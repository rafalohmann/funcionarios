            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class MotivoAfastamentoRepository : BaseRepository<MotivoAfastamento>, IMotivoAfastamentoRepository
    {
        public MotivoAfastamentoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IMotivoAfastamentoRepository : IRepository<MotivoAfastamento>
    {

    }
}
