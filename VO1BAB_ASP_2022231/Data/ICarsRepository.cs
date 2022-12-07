using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public interface ICarsRepository
    {
        void Create(Cars item);
        void Delte(int id);
        Cars Read(int id);
        IEnumerable<Cars> ReadAll();
        void Update(Cars id);
    }
}