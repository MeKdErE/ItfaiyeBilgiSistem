using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IDataResult<User> GetByMail(string email);
        IDataResult<User> GetByUserName(string userName);
    }
}
