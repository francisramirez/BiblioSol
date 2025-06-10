using BiblioSol.Domain.Base;
using BiblioSol.Domain.Entities.insurance;

namespace BiblioSol.Application.Interfaces.Repositories.insurance
{
    public interface IInsuranceProviderRepository : IBaseRepository<InsuranceProvider>
    {
        Task<OperationResult> GetInsuranceProviderByNetworkTypeAsync(int networkTypeId);
    }
}
