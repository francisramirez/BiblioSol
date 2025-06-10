using BiblioSol.Application.Dtos.insurance;
using BiblioSol.Domain.Base;


namespace BiblioSol.Application.Interfaces.Services.insurance
{
    public interface INetworkTypeService
    {
        Task<OperationResult> GetAllNetworkTypesAsync();
        Task<OperationResult> GetNetworkTypeByIdAsync(int id);
        Task<OperationResult> AddNetworkTypeAsync(NetworkTypeDto networkType);
        Task<OperationResult> UpdateNetworkTypeAsync(NetworkTypeUpdateDto networkTypeUpdate);
        Task<OperationResult> DeleteNetworkTypeAsync(int id);
    }
}
