using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public class CarBrandLogic : ICarBrandLogic
    {
        ICarBrandRepository repo;
        public void Create(CarBrand item)
        {
            this.repo.Create(item);
        }

        public void Delete(int id)
        {
            this.repo.Delte(id);
        }

        public CarBrand Read(int id)
        {
            return this.Read(id);
        }

        public IEnumerable<CarBrand> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(CarBrand item)
        {
            this.repo.Update(item);

        }
    }
}
