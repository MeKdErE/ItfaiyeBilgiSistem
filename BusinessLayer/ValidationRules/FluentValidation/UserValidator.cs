using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(3);
            RuleFor(u => u.UserName).NotEmpty();
            RuleFor(u => u.UserName).MinimumLength(3);
            RuleFor(u => u.UserName).Must(StartWithA);
            RuleFor(u => u.Email).NotEmpty();
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
 