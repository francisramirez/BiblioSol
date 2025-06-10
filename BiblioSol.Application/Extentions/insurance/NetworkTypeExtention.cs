
namespace BiblioSol.Application.Extentions.insurance
{
    public static class NetworkTypeExtention
    {
        public static Domain.Entities.insurance.NetworkType ToDomainEntityAdd(this Dtos.insurance.NetworkTypeDto dto)
        {

            return new Domain.Entities.insurance.NetworkType
            {
                Name = dto.Name,
                Description = dto.Description
            };
        }
        public static Domain.Entities.insurance.NetworkType ToDomainEntityUpdate(this Dtos.insurance.NetworkTypeUpdateDto dto)
        {

            return new Domain.Entities.insurance.NetworkType
            {
                NetworkTypeId = dto.Id,
                Name = dto.Name,
                Description = dto.Description, 
            };
        }
        public static Dtos.insurance.NetworkTypeUpdateDto ToDto(this Domain.Entities.insurance.NetworkType entity)
        {

            return new Dtos.insurance.NetworkTypeUpdateDto
            {
                Id = entity.NetworkTypeId,
                Name = entity.Name,
                Description = entity.Description
            };
        }
    }
}
