using BiblioSol.Web.Models;
using BiblioSol.Web.Models.Insurance.NetworkType;

namespace BiblioSol.Web.Services.insurance
{
    public interface INetworkTypeHttpService
    {
        Task<NetWorkTypeResult> GetAllNetworkTypesAsync();
        Task<NetworkTypeGetByIdResult> GetNetworkTypeByIdAsync(int id);
        Task<OperationResult> CreateNetworkTypeAsync(NetworkTypeAddDto networkType);
        Task<OperationResult> UpdateNetworkTypeAsync(NetworkTypeUpdateDto networkType);
      
    }
}
