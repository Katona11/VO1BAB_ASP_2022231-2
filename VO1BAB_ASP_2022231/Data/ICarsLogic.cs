using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public interface ICarsLogic
    {
        void Create(Cars item);
        void Delete(int id);
        Cars Read(int id);
        IEnumerable<Cars> ReadAll();
        void Update(Cars item);
    }
}