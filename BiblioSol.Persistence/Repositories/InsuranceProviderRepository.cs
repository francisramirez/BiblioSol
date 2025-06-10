

using BiblioSol.Application.Interfaces.Repositories.insurance;
using BiblioSol.Domain.Base;
using BiblioSol.Domain.Entities.insurance;
using BiblioSol.Persistence.Base;
using BiblioSol.Persistence.Context;

namespace BiblioSol.Persistence.Repositories
{
    public sealed class InsuranceProviderRepository : BaseRepository<InsuranceProvider>, IInsuranceProviderRepository
    {
        public InsuranceProviderRepository(HealtSyncContext context) : base(context)
        {
        }
        public override Task<OperationResult> AddAsync(InsuranceProvider entity)
        {
            // Here you can add any specific logic for adding an InsuranceProvider if needed
            return base.AddAsync(entity);
        }

        public Task<OperationResult> GetInsuranceProviderByNetworkTypeAsync(int networkTypeId)
        {
            throw new NotImplementedException();
        }
    }

}
