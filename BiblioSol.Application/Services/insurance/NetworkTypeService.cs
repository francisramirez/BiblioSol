

using BiblioSol.Application.Dtos.insurance;
using BiblioSol.Application.Interfaces.Repositories.insurance;
using BiblioSol.Application.Interfaces.Services.insurance;
using BiblioSol.Application.Extentions.insurance;
using BiblioSol.Domain.Base;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;


namespace BiblioSol.Application.Services.insurance
{
    public class NetworkTypeService : INetworkTypeService
    {
        private readonly INetworkTypeRepository _networkTypeRepository;
        private readonly ILogger<NetworkTypeService> _logger;
        private readonly IConfiguration _configuration;

        public NetworkTypeService(INetworkTypeRepository networkTypeRepository,
                                  ILogger<NetworkTypeService> logger,
                                  IConfiguration configuration
                                  )
        {
            _networkTypeRepository = networkTypeRepository;
            _logger = logger;
            _configuration = configuration;
        }
        public async Task<OperationResult> AddNetworkTypeAsync(NetworkTypeDto networkType)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                _logger.LogInformation("Adding a new network type: {NetworkTypeName}", networkType.Name);


                if (networkType is null)
                {
                    operationResult = OperationResult.Failure(_configuration["Error:ErrorNetworkTypeIsNull"]);
                    return operationResult;

                }
                if (await _networkTypeRepository.ExistsAsync(nt => nt.Name == networkType.Name))
                {
                    operationResult = OperationResult.Failure($"Network type with name {networkType.Name} already exists.");
                    return operationResult;
                }

                operationResult = await _networkTypeRepository.AddAsync(networkType.ToDomainEntityAdd());
            }
            catch (Exception)
            {

                _logger.LogError("An error occurred while adding the network type.");
            }
            return operationResult;

        }

        public Task<OperationResult> DeleteNetworkTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> GetAllNetworkTypesAsync()
        {
            OperationResult operationResult = new OperationResult();

            try
            {
                _logger.LogInformation("Retrieving all network types.");
                var result = await _networkTypeRepository.GetAllAsync(nt => nt.IsActive);
                if (result.IsSuccess)
                {
                    operationResult = OperationResult.Success("Network types retrieved successfully.", result.Data);
                }
                else
                {
                    operationResult = OperationResult.Failure("Failed to retrieve network types.");
                }

                _logger.LogInformation("Successfully retrieved network types.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving network types.");
                operationResult = OperationResult.Failure("An error occurred while retrieving network types.");
            }


            return operationResult;
        }

        public Task<OperationResult> GetNetworkTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> UpdateNetworkTypeAsync(NetworkTypeUpdateDto networkTypeUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
