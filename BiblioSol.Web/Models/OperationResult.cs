using BiblioSol.Web.Models.Insurance.NetworkType;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BiblioSol.Web.Models
{
    public record OperationResult
    {
        public bool issuccess { get; set; }
        public string message { get; set; }
      
     
    }
    public record NetWorkTypeResult : OperationResult
    {
        public List<NetworkTypeGetDto> data { get; set; }
    }
    public record NetworkTypeGetByIdResult : OperationResult
    {
        public NetworkTypeGetDto data { get; set; }
    }
   
}
