
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Repositories
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetOperationClaims(User user);
    }
}
