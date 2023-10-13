using CommonService.DatabaseLayer.Repositories;
using E_Commerce_Project.Models;
using FoodOrderSystemAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommonService.DatabaseLayer.Repositories;
using DataAccessLayer_DAL_.Auth;
using E_Commerce_Project.Extentions;

namespace E_Commerce_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


   
    public class ProductController : ControllerBase
    {
        private readonly IproductRepository <ProductModel> productRepository;

        public ProductController( IproductRepository<ProductModel> productRepository)
        {
            this.productRepository = productRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var ProductEntities = await productRepository.GetAllAsync();
            var ProductsDto = ProductEntities.Select(p =>
            {
               return p.toread();
            });
            return Ok(ProductsDto);

        }















    }
}
