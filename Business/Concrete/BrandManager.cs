using DataAccess.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
	public class BrandManager
	{
		private readonly BrandDal _brandDal;
        public BrandManager()
        {
            _brandDal = new BrandDal();
        }
        public void Add(Brand brand)
		{
			if (BrandNameIsEmpty(brand) && BrandNameLength(brand) &&
				BrandStatusIsEmpty(brand))
			{
				_brandDal.Add(brand);
			}
			else
			{
				throw new Exception("Ekleme işlemi başarısız!");
			}
		}

		public List<Brand> GetAll()
		{
			return _brandDal.GetAll();
		}

		public Brand GetById(int id)
		{
			Brand checkBrand = _brandDal.GetById(id);
			if (checkBrand != null)
			{
				return checkBrand;
			}
			else
			{
				throw new Exception("İlgili id sahip marka bulunamadı.");
			}
			
		}
		public void Update(Brand brand)
		{
			if (BrandNameIsEmpty(brand) && BrandNameLength(brand) &&
				BrandStatusIsEmpty(brand))
			{
				_brandDal.Update(brand);
			}
			else
			{
				throw new Exception("Güncelleme işlemi başarısız!");
			}
			
		}

		public void Remove(int id)
		{
			Brand checkBrand = _brandDal.GetById(id);
			if (checkBrand != null)
			{
				_brandDal.Remove(checkBrand);
			}
			else
			{
				throw new Exception("İlgili id sahip marka bulunamadı.");
			}
		}




		//Business Rules
		private bool BrandNameIsEmpty(Brand brand)
		{
			if (!String.IsNullOrEmpty(brand.Name))
			{
				return true;
			}
			return false;
		}

		private bool BrandNameLength(Brand brand)
		{
			if (brand.Name.Length>2 && brand.Name.Length<=50)
			{
				return true;
			}
			return false;
		}

		private bool BrandStatusIsEmpty(Brand brand)
		{
			if (brand.Status != null)
			{
				return true;
			}
			return false;
		}
	}
}
