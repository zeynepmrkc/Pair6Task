using Business.Concrete;
using Entities.Concrete;

BrandManager brandManager = new BrandManager();
brandManager.Add(new()
{
    Id = 3,
    Name = "Brand 3",
    Status = true,
});

brandManager.Remove(1);
brandManager.Update(new()
{
    Id = 3,
    Name = "Pair6",
    Status = false,
});
List<Brand> brands = brandManager.GetAll();
foreach (Brand brand in brands)
{
    Console.WriteLine($"Id={brand.Id}\nName={brand.Name}\nCreatedDate={brand.CreatedDate}\nUpdatedDate={brand.UpdatedDate}\nStatus={brand.Status}\n----------------------------------------");
}


Brand brand2 = brandManager.GetById(2);
Console.WriteLine($"Id={brand2.Id}\nName={brand2.Name}\nCreatedDate={brand2.CreatedDate}\nUpdatedDate={brand2.UpdatedDate}\nStatus={brand2.Status}\n----------------------------------------");