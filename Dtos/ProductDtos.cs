namespace E_Commerce_Project.Dtos
{
  public record AddProductDto(string Name ,IFormFile img , decimal price , int CategoryId , int MenimumQuantity  , decimal Discount_Rate);
  public record DisplayProductDto(string Name ,string imgurl , decimal totalprice , decimal SalesPrice );
  public record Productfilter(string Name ,int CategoryId, decimal MaxRange , decimal MinRange );


}
