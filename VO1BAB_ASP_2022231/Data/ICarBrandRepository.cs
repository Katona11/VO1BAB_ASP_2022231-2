using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public interface ICarBrandRepository
    {
        void Create(CarBrand item);
        void Delte(int id);
        CarBrand Read(int id);
        IEnumerable<CarBrand> ReadAll();
        void Update(CarBrand id);
    }
}