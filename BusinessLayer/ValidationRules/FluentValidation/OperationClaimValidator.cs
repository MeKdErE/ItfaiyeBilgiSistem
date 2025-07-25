using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class OperationClaimValidator : AbstractValidator<OperationClaim>
    {
        public OperationClaimValidator()
        {
            RuleFor(oc => oc.Name).NotEmpty();
            RuleFor(oc => oc.Name).MinimumLength(3);
            //RuleFor(oc => oc.Name).Must(StartWithA).WithMessage("Yetkiler A Harfi ile Başlamalı. ");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
