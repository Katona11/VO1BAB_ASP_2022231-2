using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public class CarsRepository : ICarsRepository
    {
        ApplicationDbContext ctx;

        public CarsRepository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(Cars item)
        {
            ctx.cars.Add(item);
            ctx.SaveChanges();
        }

        public IEnumerable<Cars> ReadAll()
        {
            return ctx.cars;
        }

        public Cars Read(int id)
        {
            return this.ctx.cars.FirstOrDefault(t => t.CarsID == id);
        }

        public void Update(Cars id)
        {
            var olditem = Read(id.CarsID);
            //foreach (var item in olditem.GetType().GetProperties())
            //{
            //    item.SetValue(olditem, item.GetValue(id));
            //}
            olditem.CarsID = id.CarsID;
            olditem.CarBrandID = id.CarBrandID;            
            olditem.Type = id.Type;
            olditem.LicensePlateNumber = id.LicensePlateNumber;           
            olditem.Year = id.Year;           
            olditem.PerformanceInHP = id.PerformanceInHP;
            ctx.SaveChanges();



        }
        public void Delte(int id)
        {
            var item = Read(id);
            ctx.cars.Remove(item);
            ctx.SaveChanges();
        }
    }
}
