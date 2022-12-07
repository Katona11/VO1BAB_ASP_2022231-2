using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public interface ICarBrandLogic
    {
        void Create(CarBrand item);
        void Delete(int id);
        CarBrand Read(int id);
        IEnumerable<CarBrand> ReadAll();
        void Update(CarBrand item);
    }
}