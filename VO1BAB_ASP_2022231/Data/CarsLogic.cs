using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public class CarsLogic : ICarsLogic
    {
        ICarsRepository repo;

        public CarsLogic(ICarsRepository repo)
        {
            this.repo = repo;
        }

        public void Create(Cars item)
        {
            if (item.Year < 1950)
            {
                throw new ArgumentException("The year is too short!");
            }
            else
            {
                this.repo.Create(item);
            }
        }

        public void Delete(int id)
        {
            this.repo.Delte(id);
        }

        public Cars Read(int id)
        {
            var item = this.repo.Read(id);
            if (item == null)
            {
                throw new ArgumentException("The Car not exist!");
            }
            else
            {
                return item;
            }
        }

        public IEnumerable<Cars> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(Cars item)
        {
            this.repo.Update(item);
        }
    }
}

