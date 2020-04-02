using System.Linq;
using DataAccess.Interfaces;
using DataAccess.Repository;

namespace DataAccess
{
    public class ${TableName}Repository : GenericRepository<${TableName}>, I${TableName}Repository
    {
        public ${TableName}Repository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<${TableName}> I${TableName}Repository.Get${TableName}All() => GetAll().OrderByDescending(e => e.Id);
    }
}