

using BiblioSol.Application.Interfaces.Repositories.insurance;
using BiblioSol.Domain.Base;
using BiblioSol.Domain.Entities.insurance;
using BiblioSol.Persistence.Base;
using BiblioSol.Persistence.Context;

namespace BiblioSol.Persistence.Repositories
{
    public sealed class NetworkTypeRepository : BaseRepository<NetworkType>, INetworkTypeRepository
    {
        public NetworkTypeRepository(HealtSyncContext context) : base(context)
        {
        }
        public override Task<OperationResult> AddAsync(NetworkType entity)
        {
            // Here you can add any specific logic for adding a NetworkType if needed
            return base.AddAsync(entity);
        }
       
    }
   
}
