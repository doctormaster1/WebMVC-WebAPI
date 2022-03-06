using NLayer.Core.DTOs;
using NLayer.Core.Entities;

namespace NLayer.Core.Services
{
    public interface IProductServices : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWitHCatagoryDto>>> GetProductWitCatagory();
    }
}
