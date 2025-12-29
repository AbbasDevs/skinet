using Core.Entities;
namespace Core.Specifications;

public class ProductSpecification : BaseSpecification<Product>
{
    public ProductSpecification(String?Brand, String? type,string? sort):
    base(x=>
    (string.IsNullOrWhiteSpace(Brand) || x.Brand == Brand) &&  
    (string.IsNullOrWhiteSpace(type) || x.Type==type))
    {
        switch(sort)
        {
            case "priceAsc":
                AddOrderBy(x=>x.Price);
                break;
            case "priceDesc":
                AddOrderByDescending(x=>x.Price);
                break;
            default:
                AddOrderBy(x=>x.Name);
                break;
        }
    }

}