using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class ProductServices : Service<Product>, IProductServices
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductServices(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        //public async Task<List<ProductWitHCatagoryDto>> GetProductWitCatagory()
        //{
        //    var products = await _productRepository.GetProductWitCatagory();
        //    var productDto = _mapper.Map<List<ProductWitHCatagoryDto>>(products);
        //    return productDto;
        //}

        public async Task<CustomResponseDto<List<ProductWitHCatagoryDto>>> GetProductWithCatagory()
        {
            var products = await _productRepository.GetProductWitCatagory();
            var productDto = _mapper.Map<List<ProductWitHCatagoryDto>>(products);
            return CustomResponseDto<List<ProductWitHCatagoryDto>>.Success(200, productDto);
        }
    }
}
