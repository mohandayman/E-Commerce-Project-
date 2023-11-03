using CommonService.DatabaseLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace E_Commerce_Project.Models
{
    public class ProductModel : Iproduct
    {
        [Key] 
        public string ProductCode { get ; set; }
        public string Name  { get; set; }
        public string ImgUrl { get; set; }
        public decimal price  { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId  { get; set; }
        public CategoryModel  Category     { get; set; }
        public int  Minimum_Quantity { get; set; }
        [Range(0, 1, ErrorMessage = "Discount rate must be between 0 and 1.")]
        public decimal  Discount_Rate { get; set; }
    }
}
