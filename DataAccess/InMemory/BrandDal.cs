using Entities.Concrete;

namespace DataAccess.InMemory
{
	public class BrandDal
	{
		private readonly List<Brand> _brands;
        public BrandDal()
        {
            _brands = new List<Brand>();
            _brands.Add(new Brand()
            {
                Id = 1,
                Name = "Brand 1",
                UpdatedDate = null,
                Status = true
            });
			_brands.Add(new Brand()
			{
				Id = 2,
				Name = "Brand 2",
				UpdatedDate = DateTime.Now.AddDays(1),
				Status = true
			});
		}

		public void Add(Brand brand)
		{
			_brands.Add(brand);
		}
		public List<Brand> GetAll()
		{
			return _brands;
		}
		public Brand GetById(int id)
		{
			return _brands.Find(b => b.Id == id);
		}
		public void Remove(Brand brand)
		{
			_brands.Remove(brand);
		}
		public void Update(Brand brand)
		{
			Brand updatedBrand = _brands.Find(b => b.Id == brand.Id);
			if (updatedBrand != null)
			{
				updatedBrand.Name = brand.Name;
				updatedBrand.Status = brand.Status;
				updatedBrand.UpdatedDate = DateTime.Now;
			}
			else
			{
				throw new Exception("Güncelleme işlemi hatası!");
			}
		}
    }
}
