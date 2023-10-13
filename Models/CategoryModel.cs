using CommonService.DatabaseLayer.Models;

namespace E_Commerce_Project.Models
{
    public class CategoryModel:IEntity<int>
    {
        public int Id { get; set ; }

        public string Name { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}
