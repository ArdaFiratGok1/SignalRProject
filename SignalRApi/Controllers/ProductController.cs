using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entitites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListProduct()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            var productEntity = _mapper.Map<Product>(createProductDto);
            _productService.TAdd(productEntity);
            return Ok("successfully added");
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("successfully deleted");

        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var productEntity = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(productEntity);
            return Ok("successfully updated");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _mapper.Map<GetProductDto>(_productService.TGetById(id));
            return Ok(value);
        }

        [HttpGet("GetProductsWithCategory")]
        public IActionResult GetProductsWithCategory()
        {
            var values = _mapper.Map<List<ResultProductWithCategoryDto>>(_productService.TGetProductsWithCategory());
            return Ok(values);
        }
        

    }
}
