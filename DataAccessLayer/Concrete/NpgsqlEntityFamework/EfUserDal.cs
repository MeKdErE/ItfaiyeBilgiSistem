
using Core.DataAccess.Concrete.NpgsqlEntityFrameworks;
using Core.Entities.Concrete;
using DataAccessLayer.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.NpgsqlEntityFamework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NpgsqlIbsContext>, IUserDal
    {
        public List<OperationClaim> GetOperationClaims(User user)
        {
            using (var context =new NpgsqlIbsContext())
            {
                var result=from operationClaim in context.OperationClaims
                           join userOperationClaim in context.UserOperationClaims
                           on operationClaim.Id equals userOperationClaim.OperationClaimId
                           where userOperationClaim.UserId == user.Id
                           select new OperationClaim { Id=operationClaim.Id, Name=operationClaim.Name};
                return result.ToList();
            }
        }
    }
}
