using System.Linq;
using DataAccess.Interfaces;
using DataAccess.Repository;

namespace DataAccess
{
    public class FormMasterRepository : GenericRepository<FormMaster>, IFormMasterRepository
    {
        public FormMasterRepository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<FormMaster> IFormMasterRepository.GetFormMasterAll() => GetAll().OrderByDescending(e => e.Id);
    }
}