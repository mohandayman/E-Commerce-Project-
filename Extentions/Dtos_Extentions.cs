using CommonService.DatabaseLayer.Repositories;
using E_Commerce_Project.Dtos;
using E_Commerce_Project.Models;
using E_Commerce_Project.Services;

namespace E_Commerce_Project.Extentions
{
    public static class Dtos_Extentions
    {
        public static ProductModel ToAdd(this AddProductDto Product)
        {
            return new ProductModel()

            {
                ProductCode = Guid.NewGuid().ToString(),
                Name = Product.Name,
                price = Product.price,
                ImgUrl = ImageManager.Upload(Product.img).URL,
                CategoryId = Product.CategoryId , 
                Discount_Rate = Product.Discount_Rate

            };
        }
        public static DisplayProductDto toread(this ProductModel Product)
        {
            var salexprice = Product.price * (1 - Product.Discount_Rate);
            return new DisplayProductDto(Product.ProductCode , Product.Name, Product.ImgUrl, Product.price, salexprice);
        }
    }
}
