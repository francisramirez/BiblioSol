using BiblioSol.Web.Models;
using BiblioSol.Web.Models.Insurance.NetworkType;

namespace BiblioSol.Web.Services.insurance
{
    public class NetworkTypeHttpService : INetworkTypeHttpService
    {
        private readonly IHttpClientFactory httpClient;
        private readonly ILogger<NetworkTypeHttpService> logger;
        private readonly IConfiguration configuration;

        public NetworkTypeHttpService(IHttpClientFactory httpClient, 
                                      ILogger<NetworkTypeHttpService> logger,
                                      IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.logger = logger;
            this.configuration = configuration;
        }

        public async Task<OperationResult> CreateNetworkTypeAsync(NetworkTypeAddDto networkType)
        {
            throw new NotImplementedException();
        }

        public async Task<NetWorkTypeResult> GetAllNetworkTypesAsync()
        {
            NetWorkTypeResult netWorkTypeResult = new NetWorkTypeResult();

            try
            {
                using (var client = httpClient.CreateClient("BiblioSolApi"))
                {
                   
                    var response = await client.GetAsync("NetworkType/GetAllNetworkTypes");

                    if (response.IsSuccessStatusCode)
                    {
                        netWorkTypeResult = await response.Content.ReadFromJsonAsync<NetWorkTypeResult>();
                    }
                    else
                    {
                        netWorkTypeResult.issuccess = false;
                        netWorkTypeResult.message = "Failed to retrieve network types.";
                    }
                }
            }
            catch (Exception ex)
            {
              this.logger.LogError(ex, "An error occurred while fetching network types.");
                netWorkTypeResult.issuccess = false;
                netWorkTypeResult.message = "An error occurred while fetching network types.";

            }

            return netWorkTypeResult;
        }

        public async Task<NetworkTypeGetByIdResult> GetNetworkTypeByIdAsync(int id)
        {
         
            NetworkTypeGetByIdResult networkTypeGetByIdResult = new NetworkTypeGetByIdResult();

            try
            {
                using (var client = httpClient.CreateClient("BiblioSolApi"))
                {

                    var response = await client.GetAsync($"NetworkType/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        networkTypeGetByIdResult = await response.Content.ReadFromJsonAsync<NetworkTypeGetByIdResult>();
                    }
                    else
                    {
                        networkTypeGetByIdResult.issuccess = false;
                        networkTypeGetByIdResult.message = "Failed to retrieve network types.";
                    }
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occurred while fetching network types.");
                networkTypeGetByIdResult.issuccess = false;
                networkTypeGetByIdResult.message = "An error occurred while fetching network types.";

            }

            return networkTypeGetByIdResult;
        }

        public async Task<OperationResult> UpdateNetworkTypeAsync(NetworkTypeUpdateDto networkType)
        {
            OperationResult netWorkTypeResult = new OperationResult();

            try
            {
                using (var client = httpClient.CreateClient("BiblioSolApi"))
                {

                    var response = await client.PostAsJsonAsync<NetworkTypeUpdateDto>("NetworkType/ModifyNetworkType", networkType);

                    if (response.IsSuccessStatusCode)
                    {
                        netWorkTypeResult = await response.Content.ReadFromJsonAsync<OperationResult>();
                    }
                    else
                    {
                        netWorkTypeResult.issuccess = false;
                        netWorkTypeResult.message = "Failed to retrieve network types.";
                    }
                }
            }
            catch (Exception ex)
            {
                netWorkTypeResult.issuccess = false;
                netWorkTypeResult.message = "An error occurred while updating network type.";
                this.logger.LogError(ex, netWorkTypeResult.message);
            }

            return netWorkTypeResult;
        }
    }
}
