using System.Linq;
using DataAccess.Interfaces;
using DataAccess.Repository;

namespace DataAccess
{
    public class ENPDetailRepository : GenericRepository<ENPDetail>, IENPDetailRepository
    {
        public ENPDetailRepository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<ENPDetail> IENPDetailRepository.GetENPDetailAll() => GetAll().OrderByDescending(e => e.Id);
    }
}