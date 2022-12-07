using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public class CarBrandRepository : ICarBrandRepository
    {
        ApplicationDbContext ctx;
        public CarBrandRepository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(CarBrand item)
        {
            ctx.carbrand.Add(item);
            ctx.SaveChanges();
        }

        public IEnumerable<CarBrand> ReadAll()
        {
            return ctx.carbrand;
        }

        public CarBrand Read(int id)
        {
            return this.ctx.carbrand.FirstOrDefault(t => t.CarBrandID == id);
        }

        public void Update(CarBrand id)
        {
            var olditem = Read(id.CarBrandID);
            foreach (var item in olditem.GetType().GetProperties())
            {
                item.SetValue(olditem, item.GetValue(id));
            }
        }

        public void Delte(int id)
        {
            var item = Read(id);
            ctx.carbrand.Remove(item);
        }
    }
}
